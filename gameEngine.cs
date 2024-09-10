using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public enum GameState
    {
        InProgress,
        Complete,
        GameOver
    }
    public class gameEngine
    {
        int gameState=(int)GameState.InProgress;
        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;

        public level level;
        private int levelnum;
        private Random random;
        

        public gameEngine(int nlevelnum) 
        {
            random = new Random();
            levelnum = nlevelnum;
            level = new level(random.Next(MIN_SIZE, MAX_SIZE), random.Next(MIN_SIZE, MAX_SIZE));
            
            
        }
        public override String ToString()
        {
            return level.ToString();
        }

        private bool  MoveHero(direction disredMove) // checks if the hero has made a move
        {
            //tile targetTile = null;
            tile targetTile = level.Hero.vision[(int)disredMove];

            if (targetTile is EmptyTile)
            {
                level.Swoptiles(level.Hero,targetTile);
                level.Hero.UpdateVision(level);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void triggermovement(direction DirMOv)
        {
            MoveHero(DirMOv);
        }
        public void NextLevel()
        {

        }
    }
}
