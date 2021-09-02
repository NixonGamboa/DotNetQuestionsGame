using System.Collections.Generic;
using HelloWorld.model;
using HelloWorld.utils;
using MongoDB.Driver;

namespace HelloWorld.repositories
{

    
    public class QuestionRepository
    {
        public IMongoCollection<Question> connect(){
            var settings = MongoClientSettings.FromConnectionString(Constants.MONGO_URI);
            var client = new MongoClient(settings);
            var database = client.GetDatabase(Constants.MONGO_DB);
            var collection = database.GetCollection<Question>("preguntas");
            return collection;
        }

        public void create(Question question){
            var collectionDb = connect();
            collectionDb.InsertOne(question);
        }

        public List<Question> getQuestions(int category){
            var collectionDb = connect();
            List<Question> questions = collectionDb.Find(d => d.category == category).ToList();
            return questions;
        }

    
        
    }
}