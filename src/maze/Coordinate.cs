using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {

            return "(" + x + "," + y + ")";
        }
        public void printDebug()
        {
            System.Diagnostics.Debug.Write(this);
        }

        public void printDebugln()
        {
            System.Diagnostics.Debug.WriteLine(this);
        }
    }
}
