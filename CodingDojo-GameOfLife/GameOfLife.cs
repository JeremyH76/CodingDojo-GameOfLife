using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_GameOfLife
{
    public class GameOfLife
    {
        public static bool[,] NextGen(bool[,] grid)
        {
            bool[,] newGrid = new bool[grid.GetLength(0), grid.GetLength(1)];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    int neigh = GetNeighbour(grid, i, j);
                    if (grid[i, j])
                    {
                        if (neigh == 2 || neigh == 3)
                        {
                            newGrid[i, j] = true;
                        }
                    }
                    else
                    {
                        if (neigh == 3)
                        {
                            newGrid[i, j] = true;
                        }
                    }
                }
            }
            return newGrid;
        }

        private static int GetNeighbour(bool[,] grid, int i, int j)
        {
            int count = 0;
            if (i != 0 && j != 0 && grid[i - 1, j - 1]) { count++; }
            if (i != 0 && grid[i - 1, j]) { count++; }
            if (i != 0 && j != grid.GetLength(1) - 1 && grid[i - 1, j + 1]) { count++; }
            if (j != 0 && grid[i, j - 1]) { count++; }
            if (j != grid.GetLength(1) - 1 && grid[i, j + 1]) { count++; }
            if (i != grid.GetLength(0) - 1 && j != 0 && grid[i + 1, j - 1]) { count++; }
            if (i != grid.GetLength(0) - 1 && grid[i + 1, j]) { count++; }
            if (i != grid.GetLength(0) - 1 && j != grid.GetLength(1) - 1 && grid[i + 1, j + 1]) { count++; }
            return count;
        }
    }
}
