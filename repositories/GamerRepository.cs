using System.Collections.Generic;
using HelloWorld.model;
using MongoDB.Driver;

namespace HelloWorld.repositories
{
    public class GamerRepository
    {
        public IMongoCollection<Gamer> connect(){
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PauloLaSerna:12345@cluster0.5ixtz.mongodb.net/questionGame?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("questionGame");
            var collection = database.GetCollection<Gamer>("jugadores");
            return collection;
        }

        public void create(Gamer newGamer){
            var collectionDb = connect();
            collectionDb.InsertOne(newGamer);
        }

        public List<Gamer> getGamers(){
            var collectionDb = connect();
            List<Gamer> gamers = collectionDb.Find(d => true).ToList();
            return gamers;
        }

    }
}