using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    public class EmptyTile : tile
    {
        tile Tile;

        public EmptyTile(Position position) : base(position)
        {
            
        }
        public override char Display
        {
            get {  return '.' ; }
            
        }
    }
}
