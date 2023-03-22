using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Solver
    {

        public char[,]? maze { get; }
        public Coordinate start;
        public HashSet<Coordinate> setTreasure = new HashSet<Coordinate>();
        public int rowLen { get; }
        public int colLen { get; }
        public Form1? form;

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

        public Solver(char[,] mat, int rowLen, int colLen, Form1 form)
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
                    } else if (mat[i,j] == 'T')
                    {
                        setTreasure.Add(new Coordinate(i, j));
                    }
                }
            }
            this.form = form;
        }

        public List<Coordinate> solveByDFS() 
        {
            // TO DO
            List<Coordinate> res = new List<Coordinate>();
            return res;
        }
        public List<Coordinate> solveByBFS() 
        {
            // TO DO
            var visited = new bool[rowLen,colLen];

            var queue = new Queue<Coordinate>();
            queue.Enqueue(start);
            
            var prevCoor = new Coordinate[rowLen, colLen];
            var prevStart = start;
            List<Coordinate> rute = new List<Coordinate>();

            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited[vertex.y,vertex.x])
                    continue;
                visited[vertex.y,vertex.x] = true;  

                if (maze[vertex.y,vertex.x] == 'T')
                {
                    var tmp = vertex;
                    var subRute = new List<Coordinate>();
                    while(tmp != prevStart) {
                        subRute.Add(tmp);
                        tmp = prevCoor[tmp.y,tmp.x];
                    }
                    subRute.Reverse();
                    rute.AddRange(subRute);
                    visited = new bool[rowLen, colLen];
                    prevStart = vertex;
                }

                if ((vertex.x + 1 < colLen) && !visited[vertex.y, vertex.x + 1] && (maze[vertex.y,vertex.x + 1] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y, vertex.x + 1));
                prevCoor[vertex.y, vertex.x + 1] = vertex;
                }
                if ((vertex.y + 1 < rowLen) && !visited[vertex.y + 1, vertex.x] && (maze[vertex.y + 1, vertex.x] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y + 1, vertex.x));
                prevCoor[vertex.y + 1, vertex.x] = vertex;
                }
                if ((vertex.y - 1 > 0) && !visited[vertex.y - 1, vertex.x] && (maze[vertex.y -1 , vertex.x] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y - 1, vertex.x));
                prevCoor[vertex.y - 1, vertex.x] = vertex;
                }
                if ((vertex.x - 1 > 0) && !visited[vertex.y, vertex.x - 1] && (maze[vertex.y, vertex.x - 1] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y, vertex.x - 1));
                    prevCoor[vertex.y, vertex.x - 1] = vertex;
                }
            }
            return rute;
        }
    }
}
