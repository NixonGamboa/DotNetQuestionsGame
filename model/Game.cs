using HelloWorld.utils;

namespace HelloWorld.model
{
    public class Game
    {
        public int score {get; set;}

        public int round {get; set;}
        
        public int maxRound {get; set;}
        
        public Gamer gamer {get; set;} 

        public bool finish {get; set;}

        public Game(int maxRound, Gamer gamer){
            this.score = 0;
            this.round = 1;
            this.finish = false;
            this.maxRound = maxRound;
            this.gamer = gamer;
        }

        public void winLevel(int points){
            this.score = score+points;
            this.round = round+1;
            if( this.round > Constants.MAX_ROUNDS){
                this.finishGame(true);
            }
        }

        public void finishGame(bool finished){
            this.finish = finished;
        }

        
    }
}