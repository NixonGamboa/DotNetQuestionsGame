using HelloWorld.model;
using MongoDB.Driver;

namespace HelloWorld.repositories
{

    
    public class QuestionRepository
    {
        public IMongoCollection<Question> connect(){
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PauloLaSerna:12345@cluster0.5ixtz.mongodb.net/questionGame?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("questionGame");
            var collection = database.GetCollection<Question>("preguntas");
            return collection;
        }

        public void create(Question question){
            var collectionDb = connect();
            collectionDb.InsertOne(question);
        }
        
    }
}