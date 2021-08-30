using System.Collections.Generic;
namespace HelloWorld.model
{
    public class Pregunta
    {
        public string question {get;  set;}
        public List<string> options {get;  set;}
        public string answer {get;  set;}
        public Pregunta(string v1, List<string> p, string v2)
        {
            this.question = v1;
            this.options =  p;
            this.answer = v2;
        }

        

        
    }
}