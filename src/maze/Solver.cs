namespace maze
{
    internal class Solver
    {

        public char[,] maze { get; } = new char[10, 10];
        public Coordinate start = new Coordinate(0,0);
        public List<Coordinate> listTreasure = new List<Coordinate>();
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
                        listTreasure.Add(new Coordinate(j, i));
                    }
                }
            }
            this.form = form;
        }

        public List<Coordinate> solveByDFS(bool isTSP) 
        {
            List<Coordinate> res = new List<Coordinate>();
            var dikunjungi = new bool[rowLen, colLen];
            var stack = new Stack<Coordinate>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                var now = stack.Peek();

                if (dikunjungi[now.y, now.x])
                {
                    continue;
                }
                res.Add(now);
                dikunjungi[now.y, now.x] = true;
                if (maze[now.y, now.x] == 'T')
                {
                    listTreasure.Remove(now);
                }
                if (listTreasure.Count > 0)
                {
                    bool adaYangDikunjungi = false;
                    if (now.y - 1 >= 0 && !dikunjungi[now.y - 1, now.x] && maze[now.y - 1, now.x] != 'X')
                    {
                        stack.Push(new Coordinate(now.x, now.y - 1));
                        adaYangDikunjungi = true;
                    }
                    if (now.x - 1 >= 0 && !dikunjungi[now.y, now.x - 1] && maze[now.y, now.x - 1] != 'X')
                    {
                        stack.Push(new Coordinate(now.x - 1, now.y));
                        adaYangDikunjungi = true;
                    }
                    if (now.y + 1 < rowLen && !dikunjungi[now.y + 1, now.x] && maze[now.y + 1, now.x] != 'X')
                    {
                        stack.Push(new Coordinate(now.x, now.y + 1));
                        adaYangDikunjungi = true;
                    }
                    if (now.x + 1 < colLen && !dikunjungi[now.y, now.x + 1] && maze[now.y, now.x + 1] != 'X')
                    {
                        stack.Push(new Coordinate(now.x + 1, now.y));
                        adaYangDikunjungi = true;
                    }
                    if (!adaYangDikunjungi)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    if (isTSP)
                    {
                        stack.Pop();
                    } else
                    {
                        break;
                    }
                }

            }
            return res;
        }
        public List<Coordinate> solveByBFS(bool isTSP) 
        {
            List<Coordinate> rute = new List<Coordinate>();
            var visited = new bool[rowLen,colLen];
            var prevCoor = new Coordinate[rowLen, colLen];
            var prevStart = start;
            var queue = new Queue<Coordinate>();
            bool goBack = false;
            queue.Enqueue(start);
            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited[vertex.y,vertex.x])
                    continue;
                visited[vertex.y,vertex.x] = true;  

                if ((maze[vertex.y,vertex.x] == 'T' && listTreasure.Contains(vertex)) || 
                    (maze[vertex.y,vertex.x] ==  'K' && isTSP && goBack))
                {
                    var tmp = vertex;
                    var subRute = new List<Coordinate>();
                    while(tmp != prevStart) {
                        subRute.Add(tmp);
                        tmp = prevCoor[tmp.y,tmp.x];
                    }
                    subRute.Reverse();
                    rute.AddRange(subRute);
                    queue.Clear();
                    listTreasure.Remove(vertex);
                    prevStart = vertex;
                    if (listTreasure.Count == 0)
                    {
                        if (isTSP)
                        {
                            goBack = true;
                            visited = new bool[rowLen, colLen];
                        } else
                        {
                            break;
                        }
                    }
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
