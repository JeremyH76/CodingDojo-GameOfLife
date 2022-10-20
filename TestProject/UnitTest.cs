using CodingDojo_GameOfLife;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestAllGridFalse()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] result = GameOfLife.NextGen(grid);
            Assert.Equal(grid, result);
        }

        [Fact]
        public void TestOneTrueMiddle()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected = new bool[3, 3];
            grid[1, 1] = true;
            bool[,] result = GameOfLife.NextGen(grid);
            Assert.Equal(expected, result);
        }
    }
}