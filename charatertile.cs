using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public abstract class charatertile:tile
    {
        int hitpoints;
        int maximunhitpoints;
        int attackpower;
        public charatertile[] vision;
        public tile[] vission
        {
            get { return vision; }
            set { vission = value; }
        }
        public charatertile(Position position,int newhitpoints,int newattackpower) : base(position)

        {
            hitpoints=newhitpoints;
            maximunhitpoints=hitpoints;
            attackpower=newattackpower;
            vission = new tile[4];
        }
        

        public void UpdateVision(level LEveel)
        {
            LEveel.ToString();
        }

        public void takedamage(int dameg)
        {
            hitpoints -= dameg;
        }

        public void attack()
        {

        }

        public bool isdead
        {
            get { bool dead = false;
                if (hitpoints>=0)
                {
                        dead = false;
                }
                else 
                {
                    dead = true;
                } 
                return dead; }
            
        }

    }

}
