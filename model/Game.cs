namespace HelloWorld.model
{
    public class Game
    {
        public int score {get; set;}

        public int round {get; set;}
        
        public int maxRound {get; set;}
        
        public Gamer gamer {get; set;} 

        public Game(int maxRound, Gamer gamer){
            this.score = 0;
            this.round = 0;
            this.maxRound = maxRound;
            this.gamer = gamer;
        }

        
    }
}