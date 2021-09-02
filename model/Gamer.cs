using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelloWorld.model
{
    public class Gamer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id {get; set;}

        [BsonElement("nombre")]
        public string name {get; set;}
        
        [BsonElement("monedas")]
        public int coins {get; set;}

        public Gamer(string name, int coins){
            this.name = name;
            this.coins = coins;
        }
    }
}