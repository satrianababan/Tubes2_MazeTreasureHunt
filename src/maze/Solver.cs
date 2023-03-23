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
			dikunjungi[start.y, start.x] = true;
			while (stack.Count > 0)
			{
				var now = stack.Peek();
				searchOrder.Add(now);
				path.Add(now);       
				if (tmpMaze[now.y, now.x] == 'T')
				{
					tmpMaze[now.y, now.x] = 'R';
					treasureFound++;
				}
				if (treasureFound < totalTreasure)
				{
					if (now.x + 1 < colLen && !dikunjungi[now.y, now.x + 1] && tmpMaze[now.y, now.x + 1] != 'X')
					{
						stack.Push(new Coordinate(now.x + 1, now.y));
						dikunjungi[now.y, now.x + 1] = true;
					}
					else if (now.y + 1 < rowLen && !dikunjungi[now.y + 1, now.x] && tmpMaze[now.y + 1, now.x] != 'X')
					{
						stack.Push(new Coordinate(now.x, now.y + 1));
						dikunjungi[now.y + 1, now.x] = true;
					}
					else if (now.x - 1 >= 0 && !dikunjungi[now.y, now.x - 1] && tmpMaze[now.y, now.x - 1] != 'X')
					{
						stack.Push(new Coordinate(now.x - 1, now.y));
						dikunjungi[now.y, now.x - 1] = true;
					}
					else if (now.y - 1 >= 0 && !dikunjungi[now.y - 1, now.x] && tmpMaze[now.y - 1, now.x] != 'X')
					{
						stack.Push(new Coordinate(now.x, now.y - 1));
						dikunjungi[now.y - 1, now.x] = true;
					}
					else
					{
						stack.Pop();
						searchOrder.RemoveAt(searchOrder.Count-1);

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
			visited[start.y, start.x] = true;
			rute.Add(start);
			while (queue.Count > 0)
			{
				var vertex = queue.Dequeue();
				searchOrder.Add(vertex);
                System.Diagnostics.Debug.WriteLine("sekarang : " + vertex);
                if (tmpMaze[vertex.y,vertex.x] == 'T')
				{

					if (tmpMaze[vertex.y, vertex.x] == 'T')
					{
						tmpMaze[vertex.y, vertex.x] = 'R';
						foundTreasure++;
						queue.Clear();

					}
					if (foundTreasure == totalTreasure)
					{
                        System.Diagnostics.Debug.WriteLine("TREASURE HABIS");
                        if (isTSP)
						{
							goBack = true;
						} else
						{
                            var subRute = getSubRoute(prevStart, vertex, prevCoor);
							rute.AddRange(subRute);
                            break;
						}
					}
				} 
				else if (vertex == start && goBack)
				{
                    var subRute = getSubRoute(prevStart, vertex, prevCoor);
                    rute.AddRange(subRute);
                    break;
				}
				if (queue.Count == 0 && !isThereTetangga(vertex, tmpMaze, visited))
				{
					var subRute = getSubRoute(prevStart, vertex, prevCoor);
                    rute.AddRange(subRute);
                    prevStart = vertex;
                    visited = new bool[rowLen, colLen];
                    visited[vertex.y, vertex.x] = true;
                }
				if ((vertex.x + 1 < colLen) && !visited[vertex.y, vertex.x + 1] && (tmpMaze[vertex.y, vertex.x + 1] != 'X'))
				{
					queue.Enqueue(new Coordinate(vertex.x + 1, vertex.y));
					prevCoor[vertex.y, vertex.x + 1] = vertex;
					visited[vertex.y, vertex.x + 1] = true;
				}
				if ((vertex.y + 1 < rowLen) && !visited[vertex.y + 1, vertex.x] && (tmpMaze[vertex.y + 1, vertex.x] != 'X'))
				{
					queue.Enqueue(new Coordinate(vertex.x, vertex.y + 1));
					prevCoor[vertex.y + 1, vertex.x] = vertex;
					visited[vertex.y + 1, vertex.x] = true;
				}
                if ((vertex.x - 1 >= 0) && !visited[vertex.y, vertex.x - 1] && (tmpMaze[vertex.y, vertex.x - 1] != 'X'))
                {
                    queue.Enqueue(new Coordinate(vertex.x - 1, vertex.y));
                    prevCoor[vertex.y, vertex.x - 1] = vertex;
                    visited[vertex.y, vertex.x - 1] = true;
                }
                if ((vertex.y - 1 >= 0) && !visited[vertex.y - 1, vertex.x] && (tmpMaze[vertex.y - 1, vertex.x] != 'X'))
				{
					queue.Enqueue(new Coordinate(vertex.x, vertex.y - 1));
					prevCoor[vertex.y - 1, vertex.x] = vertex;
					visited[vertex.y - 1, vertex.x] = true;
				}

			}
			PathResult pathResult = new PathResult(rute,searchOrder);
			return pathResult;
		}

		private bool isThereTetangga(Coordinate c, char[,] m, bool[,] visited)
		{

			if (((c.x + 1 < colLen) && !visited[c.y, c.x + 1] && (m[c.y, c.x + 1] != 'X'))
				|| ((c.y + 1 < rowLen) && !visited[c.y + 1, c.x] && (m[c.y + 1, c.x] != 'X'))
				|| ((c.y - 1 >= 0) && !visited[c.y - 1, c.x] && (m[c.y - 1, c.x] != 'X'))
				|| ((c.x - 1 >= 0) && !visited[c.y, c.x - 1] && (m[c.y, c.x - 1] != 'X')))  
			{
				return true;
			} else
			{
				return false;
			}

		}

		private List<Coordinate> getSubRoute(Coordinate startC, Coordinate endC, Coordinate[,] prevCoor)
		{
			var now = new Coordinate(endC);
            var subRute = new List<Coordinate>();
            while (now != startC)
            {
                subRute.Add(now);
                now = prevCoor[now.y, now.x];
            }
            subRute.Reverse();
			return subRute;
        } 
	}
}
