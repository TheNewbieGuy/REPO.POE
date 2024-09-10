using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public class Position
    {
        private int x_position; 
        private int y_position;

        
        public Position(int x, int y)
        {
            x_position = x;
            y_position = y;
        }

        public int X
        {
            get { return x_position; }
            set { x_position = value; }
        }

        public int Y
        {
            get { return y_position; }
            set { y_position = value; }
        }
    }
}
