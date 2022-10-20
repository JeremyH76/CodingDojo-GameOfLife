using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_GameOfLife
{
    public static class ShowConsole
    {
        public static void Show(bool[,] grid)
        {
            string toShow = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j]) { toShow += 'X'; }
                    else { toShow += ' '; }
                }
                toShow += '\n';
            }
            Console.WriteLine(toShow);
        }
    }
}
