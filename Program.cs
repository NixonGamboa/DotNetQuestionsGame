
using System.Linq;
using System.Collections.Generic;
using System;
using HelloWorld.model;
using HelloWorld.repositories;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nixon!");
            var options = new List<string>() {"3", "4" , "5"};
            var questionOne = new Question() {
                statement = "2+2",
                options = options,
                correct = "4",
                category = 1
             }; 

            var Repo = new QuestionRepository();

            Repo.create(questionOne);

            Console.WriteLine(questionOne.statement);
            questionOne.options.ForEach(option => Console.WriteLine(option) );
            
            Console.WriteLine(questionOne.isCorrect("4"));
        }
    }
}
