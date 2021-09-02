
using System.Linq;
using System.Collections.Generic;
using System;
using HelloWorld.model;
using HelloWorld.repositories;
using System.Threading;
using HelloWorld.utils;

namespace HelloWorld
{
    class Program {
        private static QuestionRepository questionRepo = new QuestionRepository();
        private static GamerRepository gamerRepo =  new GamerRepository();
        private static Random random = new Random();

        static void Main(string[] args){
            Console.WriteLine("Bienvenido a quien quiere ser millonario:: Ingresa tu opcion:");
            Gamer gamer = queryGamer();
            Console.WriteLine(gamer.name);
            Console.WriteLine(gamer.id);
            Console.WriteLine("Iniciando el Juego...");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("...");
                Thread.Sleep(500);
            }
            Game game = new Game(Constants.MAX_ROUNDS, gamer);
            int score =  play(game);
            gamer.addCoins(score);
            

            Console.WriteLine("Bye Nixon!");

            
        }

        private static Gamer queryGamer(){
            List<Gamer> gamers = gamerRepo.getGamers();
            Console.WriteLine("Selecciona tu nombre:");
            Console.WriteLine("0. Nuevo Jugador");
            for (int i = 0; i < gamers.Count; i++){
                Console.WriteLine($"{i+1}. {gamers[i].name}");
            }
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 0){
                Console.WriteLine("Escribe el nombre:");
                var name = Console.ReadLine();
                Gamer gamer = new Gamer(name, 0);
                gamerRepo.create(gamer);
                return gamer;
            }
            return gamers[input-1];
        }

        private static int play(Game game){
                while (!game.finish)  {
                    List<Question> questions = questionRepo.getQuestions(game.round);
                    Question question = questions[random.Next(questions.Count)];
                    Console.WriteLine(question.statement);
                    List<string> options = question.options;
                    for (int i = 0; i < options.Count; i++) {
                        Console.WriteLine("{0}. -> {1} ",i+1,options[i]);
                    }
                    Console.WriteLine("...Presione cualquier numero para retirarse con {0} puntos", game.score);
                    var response =  Convert.ToInt32(Console.ReadLine())-1;
                    if(response < 0 || response >= options.Count){
                        Console.WriteLine("### Usted ha elegido retirarse con {0} puntos", game.score);
                        game.finishGame(true);
                        return game.score;
                    }
                    if(!question.isCorrect(options[response])){
                        Console.WriteLine("Respuesta incorrecta, ha perdido el juego y todos sus puntos");
                        game.finishGame(true);
                        return 0;
                    }  
                    int points = (int)(Math.Sqrt(game.round)*10);
                    Console.WriteLine($"Felicidades, respuesta correcta! Ganaste {points} puntos");
                    game.winLevel(points);
                }
                return game.score;
        }

        //Un metodo para generar multiples preguntas matematicas y guardarlas en base de datos
        private static void generateQuestions(){
            for (int i = 3; i < 8; i++) {
                var questionOne = new Question() {
                    statement = $"cuanto es {i}^3? ",
                    options = new List<string>() { $"{i*i*i+9}", $"{i*i*i-2}" , $"{i*i*i}", $"{i*i}"},
                    correct = $"{i*i*i}",
                    category = 5
                }; 
                questionRepo.create(questionOne);
            }
        }
    }
}