using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public class herotile: charatertile
    {
        public Position position;
        private int hitpoints;
        private int maximumthopiton;
        private int attack;
        private tile[] vision;

       public herotile(Position position, int hitpoints, int attack) :base(position, 40, 5)
        {
            this.position = position;
            this.hitpoints = hitpoints;
            this.maximumthopiton = hitpoints;
            this.attack = attack;
        }
        
        public override char Display
        { 
            get {
                    char dead = '▼';
                    if (isdead==true)
                    {
                        dead = 'X';
                    }
                    else if(isdead==false)
                    {
                        dead = '▼';
                    }
                    return dead;
                }
            }

        }
    }

