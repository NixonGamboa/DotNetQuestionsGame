using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelloWorld.model
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id {get; set;}
        
        [BsonElement("enunciado")]
        public string statement {get;  set;}

        [BsonElement("opciones")]
        public List<string> options {get;  set;}
        
        [BsonElement("respuesta")]
        public string correct {get;  set;}
        [BsonElement("categoria")]
        public int category {get; set;}
        /*public Question(string statement, List<string> options, string answer, int category){
            this.statement = statement;
            this.options =  options;
            this.answer = answer;
            this.category = category;
        }*/

        public bool isCorrect(string answer) => answer == this.correct;

        
    }
}