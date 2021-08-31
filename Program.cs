
using System.Linq;
using System.Collections.Generic;
using System;
using HelloWorld.model;
using HelloWorld.repositories;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello Nixon!");
            var Repo = new QuestionRepository();

            // for (int i = 3; i < 8; i++) {
            //     var questionOne = new Question() {
            //         statement = $"cuanto es {i}^3? ",
            //         options = new List<string>() { $"{i*i*i+9}", $"{i*i*i-2}" , $"{i*i*i}", $"{i*i}"},
            //         correct = $"{i*i*i}",
            //         category = 5
            //     }; 
            //     Repo.create(questionOne);
            // }
            Console.WriteLine("Bienvenido a quien quiere ser millonario:: Ingresa tu opcion:");
            Console.WriteLine("1. Iniciar el Juego");

            var game = new Game()

           



            List<Question> abc = Repo.getQuestions(5);
            abc.ForEach(q =>{
                Console.WriteLine(q.statement);
                q.options.ForEach(option => Console.WriteLine(option) );
            
                Console.WriteLine(q.isCorrect("4"));
            });
            Console.WriteLine("Bye Nixon!");

            
        }
    }
}