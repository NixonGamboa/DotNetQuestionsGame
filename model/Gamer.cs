namespace HelloWorld.model
{
    public class Gamer
    {
        public string name {get; set;}
        public int coins {get; set;}

        public Gamer(string name, int coins){
            this.name = name;
            this.coins = coins;
        }
    }
}