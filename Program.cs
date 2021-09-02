
using System.Linq;
using System.Collections.Generic;
using System;
using HelloWorld.model;
using HelloWorld.repositories;
using System.Threading;

namespace HelloWorld
{
    class Program {
        private static QuestionRepository questionRepo = new QuestionRepository();
        private static GamerRepository gamerRepo =  new GamerRepository();

        static void Main(string[] args){
            Console.WriteLine("Bienvenido a quien quiere ser millonario:: Ingresa tu opcion:");
            Gamer gamer = queryGamer();
            Console.WriteLine("Iniciando el Juego...");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("...");
            var game = new Game();

           



            // List<Question> abc = questionRepo.getQuestions(5);
            // abc.ForEach(q =>{
            //     Console.WriteLine(q.statement);
            //     q.options.ForEach(option => Console.WriteLine(option) );
            
            //     Console.WriteLine(q.isCorrect("4"));
            // });
            Console.WriteLine("Bye Nixon!");

            
        }

        private static Gamer queryGamer(){
            Console.WriteLine("Selecciona tu nombre:");
            Console.WriteLine("0. Nuevo Jugador");
            List<Gamer> gamers = gamerRepo.getGamers();
            for (int i = 0; i < gamers.Count; i++){
                Console.WriteLine($"{i+1}. {gamers[i]}");
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