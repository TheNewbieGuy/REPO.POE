using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{

      public abstract class tile
      {
        private int x;
        private int y;
        private Position postition;

        public int XPosition // gets and sets the x postion
        {
            get { return postition.X; }
            set { postition.X = value; }
        }

        public int YPosition // gets and sets the y position
        {
            get { return postition.Y; }
            set { postition.Y = value; }
        }
        public tile(Position position)
        {
            this.postition = position;
        }

        public abstract char  Display
        {
            get;
        }
    }
}
