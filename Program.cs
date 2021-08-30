
using System.Linq;
using System.Collections.Generic;
using System;
using HelloWorld.model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nixon!");
            var options = new List<string>() {"3", "4" , "5"};
            var questionOne = new Pregunta("2+2", options, "4");

            Console.WriteLine(questionOne.question);
            questionOne.options.ForEach(option => Console.WriteLine(option) );
            
            Console.WriteLine(questionOne.options);
        }
    }
}
