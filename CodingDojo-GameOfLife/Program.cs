

using CodingDojo_GameOfLife;

bool[,] grid = Examples.GliderGun;

Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

bool[,] newGrid;

for (int i=0; i< 200; i++)
{
    ShowConsole.Show(grid);
    newGrid = GameOfLife.NextGen(grid);
    if (newGrid.Equals(grid)) { break; }
    grid = newGrid;
    Thread.Sleep(100);
}