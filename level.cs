using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POE.level;

namespace POE
{
    public enum direction
    {
        up,
        right,
        down,
        left,
        none,
    }


    public class level
    {

        static int width = 0;
        static int height = 0;

        private herotile hero;

        public tile[,] tilesarray;
        

        public level(int nwidth, int nheight,herotile hero=null)
        {
            width = nwidth;
            height = nheight;
            tilesarray=new tile[width,height];
            initialiseTiles();
            ToString();
            
        }

        public enum tileType
        {
            empty,
            wall,
            Hero,
            exit
            
        }

        tile Createtile(tileType tiled, Position p)
        {
            tile tile=null;// insitalises the varible so it doesnt cause problems
            switch(tiled)
            {
                case tileType.empty:
                {
                    tile = new EmptyTile(p);
                    tilesarray[p.X, p.Y] = tile;
                    break;
                }
                case tileType.wall:
                {
                    tile= new walltile(p);
                    tilesarray[p.X, p.Y] = tile;
                    break;
                }
                case tileType.Hero:
                {
                    tile = new herotile(p, 40, 5);
                    tilesarray[p.X, p.Y] = tile;
                    break;
                }
                case tileType.exit:
                {
                    tile = new exitTile(p);
                    tilesarray[p.X, p.Y] = tile;
                    break;
                }
                    
            }

            return tile;
        }
        
        private tile Createtile(tileType tiled, int i, int j)
        {
            Position p = new Position(i, j);
            return Createtile(tiled,  p);
        }

        public void initialiseTiles()
        {
            for (int i = 0; i < tilesarray.GetLength(0); i++)
            {
                for(int j = 0; j < tilesarray.GetLength(1); j++)
                {
                    if (j == 0 || j == tilesarray.GetLength(1) - 1 || i == 0 || i == tilesarray.GetLength(0)-1)// checks the outermost layer of tiles
                    {
                        tilesarray[i, j] = Createtile(tileType.wall, i, j);//adds a walltype tile to the position
                    }
                    else
                    {
                        tilesarray[i, j]= Createtile(tileType.empty, i, j);//adds a emptytype tile to the position
                    }
                }
            }
        }

        public override String ToString()
        {
            String Display2d="";
            for (int i = 0; i < tilesarray.GetLength(0); i++)
            {
                for (int j = 0; j < tilesarray.GetLength(1); j++)
                {
                    Display2d += tilesarray[i, j].Display;
                }
                Display2d += "\n";
            }
            return Display2d;
        }

        private Position getrandomEmptypostition()
        {
            Random rand = new Random();
            int x = rand.Next(0,width); 
            int y = rand.Next(0, height);
            Position randomeposition = new Position(x,y);
            return randomeposition;
        }

        public void Swoptiles(tile obj1,tile obj2)
        {
            tile temp = obj1;
            obj1.XPosition=obj2.XPosition;
            obj1.YPosition=obj2.YPosition;

            obj2.XPosition= temp.XPosition;
            obj2.YPosition=temp.YPosition;

            tilesarray[obj1.XPosition, obj1.YPosition] = obj2;
            tilesarray[obj2.XPosition,obj2.YPosition]=obj1 ;
        }

        public herotile Hero
        {
            get { return hero; }
        }

    }
}
