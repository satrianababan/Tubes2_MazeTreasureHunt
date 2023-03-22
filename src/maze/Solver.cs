using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Solver
    {

        public char[,]? maze { get; }
        public Coordinate start;
        public int rowLen { get; }
        public int colLen { get; }

        public Solver()
        {
            maze = new char[10, 10];
            this.rowLen = 10;
            this.colLen = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    maze[i, j] = 'R';
                }
            }
            start = new Coordinate(0,0);
        }

        public Solver(char[,] mat, int rowLen, int colLen)
        {
            this.maze = mat;
            this.rowLen = rowLen;
            this.colLen = colLen;
            for (int i = 0;i < rowLen; i++)
            {
                for (int j = 0;j < colLen; j++)
                {
                    if (mat[i,j] == 'K')
                    {
                        start = new Coordinate(i, j);
                        return;
                    }
                }
            }
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
            var visited = new HashSet<Coordinate>();

            var queue = new Queue<Coordinate>();
            queue.Enqueue(start);
            
            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;
                visited.Add(vertex);

                if ((vertex.x + 1 < colLen) && !visited.Contains(new Coordinate(vertex.x + 1, vertex.y)) && (maze[vertex.x+1,vertex.y] != 'X'))
                    queue.Enqueue(new Coordinate(vertex.x + 1, vertex.y));
                if ((vertex.y + 1 < rowLen) && !visited.Contains(new Coordinate(vertex.x, vertex.y + 1)) && (maze[vertex.x, vertex.y + 1] != 'X'))
                    queue.Enqueue(new Coordinate(vertex.x, vertex.y + 1));
                if ((vertex.x - 1 > 0) && !visited.Contains(new Coordinate(vertex.x - 1, vertex.y)) && (maze[vertex.x - 1, vertex.y] != 'X'))
                    queue.Enqueue(new Coordinate(vertex.x - 1, vertex.y));
                if ((vertex.y - 1 > 0) && !visited.Contains(new Coordinate(vertex.x, vertex.y - 1)) && (maze[vertex.x, vertex.y - 1] != 'X'))
                    queue.Enqueue(new Coordinate(vertex.x, vertex.y - 1));
            }
            List<Coordinate> res = new List<Coordinate>();


            return res;
        }
    }
}
