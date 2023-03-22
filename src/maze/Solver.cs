using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        start = new Coordinate(j, i);
                    } else if (mat[i,j] == 'T')
                    {
                        setTreasure.Add(new Coordinate(j, i));
                    }
                }
            }
            this.form = form;
        }

        public List<Coordinate> solveByDFS() 
        {
            // TO DO
            Console.WriteLine(1);
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    System.Diagnostics.Debug.Write(maze[i, j]);
                }
                System.Diagnostics.Debug.WriteLine("");
            }
            List<Coordinate> res = new List<Coordinate>();
            var prevStart = start;
            Coordinate[,] prev = new Coordinate[rowLen, colLen];
            var dikunjungi = new bool[rowLen, colLen];
            var stack = new Stack<Coordinate>();
            stack.Push(start);
            while (stack.Count() > 0)
            {
                var now = stack.Pop();
                if (dikunjungi[now.y, now.x])
                {
                    continue;
                }
                dikunjungi[now.y, now.x] = true;
                Form1.colorCell(now.y, now.x, Color.Blue);

                if (maze[now.y, now.x] == 'T' && setTreasure.Contains(now))
                {
                    var tmp = now;
                    var subRute = new List<Coordinate>();
                    while (tmp != prevStart)
                    {
                        subRute.Add(tmp);
                        tmp = prev[tmp.y, tmp.x];
                    }
                    subRute.Reverse();
                    res.AddRange(subRute);
                    dikunjungi = new bool[rowLen, colLen];
                    setTreasure.Remove(now);
                    prevStart = now;
                }
                if (now.y - 1 >= 0 && !dikunjungi[now.y - 1, now.x] && maze[now.y - 1, now.x] != 'X')
                {
                    stack.Push(new Coordinate(now.x, now.y - 1));
                    prev[now.y - 1, now.x] = now;
                }
                if (now.x - 1 >= 0 && !dikunjungi[now.y, now.x - 1] && maze[now.y, now.x - 1] != 'X')
                {
                    stack.Push(new Coordinate(now.x - 1, now.y));
                    prev[now.y, now.x - 1] = now;
                }
                if (now.y + 1 < rowLen && !dikunjungi[now.y + 1, now.x] && maze[now.y + 1, now.x] != 'X')
                {
                    stack.Push(new Coordinate(now.x, now.y + 1));
                    prev[now.y + 1, now.x] = now;
                }
                if (now.x + 1 < colLen && !dikunjungi[now.y, now.x + 1] && maze[now.y, now.x + 1] != 'X')
                {
                    stack.Push(new Coordinate(now.x + 1, now.y));
                    prev[now.y, now.x + 1] = now;
                }
            }

           
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

                if (maze[vertex.y,vertex.x] == 'T' && setTreasure.Contains(vertex))
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
                    setTreasure.Remove(vertex);
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
