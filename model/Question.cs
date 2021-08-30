using System.Collections.Generic;
namespace HelloWorld.model
{
    public class Question
    {
        public string statement {get;  set;}
        public List<string> options {get;  set;}
        public string answer {get;  set;}
        public int category {get; set;}
        public Question(string statement, List<string> options, string answer, int category){
            this.statement = statement;
            this.options =  options;
            this.answer = answer;
            this.category = category;
        }

        

        
    }
}