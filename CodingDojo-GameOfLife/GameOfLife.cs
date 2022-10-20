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
            return new bool[grid.GetLength(0), grid.GetLength(1)];
        }
    }
}
