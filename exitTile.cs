using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public class exitTile:tile
    {
        public exitTile(Position position) : base(position) { }
        public override char Display
        {
            get { return '▓'; }

        }//heloo
    }
}
