using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Solver
    {

        public char[,]? maze { get; }
        public int n { get; }

        Solver()
        {
            maze = new char[10, 10];
            this.n = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    maze[i, j] = '.';
                }
            }
        }

        Solver(char[,] m, int n)
        {
            this.maze = m;
            this.n = n;
        }

        List<Coordinate> solveByDFS() 
        {
            // TO DO
            List<Coordinate> res = new List<Coordinate>();
            return res;
        }
        List<Coordinate> solveByBFS() 
        {
            // TO DO
            List<Coordinate> res = new List<Coordinate>();
            return res;
        }
    }
}
