namespace maze
{
    internal class Solver
    {

        public char[,] maze { get; } = new char[10, 10];
        public Coordinate start = new Coordinate(0,0);
        public int totalTreasure = 0;
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
        }

        public Solver(char[,] mat, int rowLen, int colLen)
        {
            this.maze = mat;
            this.rowLen = rowLen;
            this.colLen = colLen;
            this.totalTreasure = 0;
            for (int i = 0;i < rowLen; i++)
            {
                for (int j = 0;j < colLen; j++)
                {
                    if (mat[i,j] == 'K')
                    {
                        start = new Coordinate(j, i);
                    } else if (mat[i,j] == 'T')
                    {
                        totalTreasure++;
                    }
                }
            }
        }

        public PathResult solveByDFS(bool isTSP) 
        {
            char[,] tmpMaze = (char[,]) maze.Clone();
            List<Coordinate> path = new List<Coordinate>();
            List<Coordinate> searchOrder = new List<Coordinate>();
            var dikunjungi = new bool[rowLen, colLen];
            var stack = new Stack<Coordinate>();
            int treasureFound = 0;
            stack.Push(start);
            while (stack.Count > 0)
            {
                var now = stack.Peek();
                if (!dikunjungi[now.y, now.x])
                {
                    searchOrder.Add(now);
                }
                path.Add(now);
                dikunjungi[now.y, now.x] = true;
                if (tmpMaze[now.y, now.x] == 'T')
                {
                    tmpMaze[now.y, now.x] = 'M';
                    treasureFound++;
                }
                if (treasureFound < totalTreasure)
                {
                    if (now.x + 1 < colLen && !dikunjungi[now.y, now.x + 1] && tmpMaze[now.y, now.x + 1] != 'X')
                    {
                        stack.Push(new Coordinate(now.x + 1, now.y));
                    }
                    else if (now.y + 1 < rowLen && !dikunjungi[now.y + 1, now.x] && tmpMaze[now.y + 1, now.x] != 'X')
                    {
                        stack.Push(new Coordinate(now.x, now.y + 1));
                    }
                    else if (now.x - 1 >= 0 && !dikunjungi[now.y, now.x - 1] && tmpMaze[now.y, now.x - 1] != 'X')
                    {
                        stack.Push(new Coordinate(now.x - 1, now.y));
                    }
                    else if (now.y - 1 >= 0 && !dikunjungi[now.y - 1, now.x] && tmpMaze[now.y - 1, now.x] != 'X')
                    {
                        stack.Push(new Coordinate(now.x, now.y - 1));
                    }
                    else
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
            PathResult pathResult = new PathResult(path,searchOrder);
            return pathResult;
        }
        public PathResult solveByBFS(bool isTSP) 
        {
            List<Coordinate> rute = new List<Coordinate>();
            List<Coordinate> searchOrder = new List<Coordinate>();
            char[,] tmpMaze = (char[,])maze.Clone();
            var visited = new bool[rowLen,colLen];
            var prevCoor = new Coordinate[rowLen, colLen];
            var prevStart = start;
            var queue = new Queue<Coordinate>();
            bool goBack = false;
            int foundTreasure = 0;
            queue.Enqueue(start);
            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited[vertex.y,vertex.x])
                    continue;
                searchOrder.Add(vertex);
                visited[vertex.y,vertex.x] = true;  

                if ((tmpMaze[vertex.y,vertex.x] == 'T') || 
                    (tmpMaze[vertex.y,vertex.x] ==  'K' && isTSP && goBack))
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
                    if (tmpMaze[vertex.y, vertex.x] == 'T')
                    {
                        tmpMaze[vertex.y, vertex.x] = 'M';
                        foundTreasure++;

                    }
                    prevStart = vertex;
                    if (foundTreasure == totalTreasure)
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
                if ((vertex.x + 1 < colLen) && !visited[vertex.y, vertex.x + 1] && (tmpMaze[vertex.y,vertex.x + 1] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y, vertex.x + 1));
                    prevCoor[vertex.y, vertex.x + 1] = vertex;
                }
                if ((vertex.y + 1 < rowLen) && !visited[vertex.y + 1, vertex.x] && (tmpMaze[vertex.y + 1, vertex.x] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y + 1, vertex.x));
                    prevCoor[vertex.y + 1, vertex.x] = vertex;
                }
                if ((vertex.y - 1 > 0) && !visited[vertex.y - 1, vertex.x] && (tmpMaze[vertex.y -1 , vertex.x] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y - 1, vertex.x));
                    prevCoor[vertex.y - 1, vertex.x] = vertex;
                }
                if ((vertex.x - 1 > 0) && !visited[vertex.y, vertex.x - 1] && (tmpMaze[vertex.y, vertex.x - 1] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.y, vertex.x - 1));
                    prevCoor[vertex.y, vertex.x - 1] = vertex;
                }
            }
            PathResult pathResult = new PathResult(rute,searchOrder);
            return pathResult;
        }
    }
}
