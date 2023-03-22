﻿using System;
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
            List<Coordinate> res = new List<Coordinate>();
            return res;
        }
    }
}
