

using CodingDojo_GameOfLife;

bool[,] grid = new bool[16, 16]
{
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, true , false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, true , false, true , false, false, false, false, false, false, false },
    { false, false, false, false, false, false, true , false, true , false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, true , true , false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }
};

Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

bool[,] newGrid;

for (int i=0; i< 100; i++)
{
    ShowConsole.Show(grid);
    newGrid = GameOfLife.NextGen(grid);
    if (newGrid.Equals(grid)) { break; }
    grid = newGrid;
    Thread.Sleep(1000);
}