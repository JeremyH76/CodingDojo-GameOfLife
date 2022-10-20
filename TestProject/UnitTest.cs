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

        [Fact]
        public void TestOneTrueCorner()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected = new bool[3, 3];
            grid[2, 2] = true;
            bool[,] result = GameOfLife.NextGen(grid);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3TrueAround()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected = new bool[3, 3];
            grid[2, 2] = true;
            grid[0, 0] = true;
            grid[0, 2] = true;
            expected[1, 1] = true;
            bool[,] result = GameOfLife.NextGen(grid);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2TrueAround()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected = new bool[3, 3];
            grid[2, 2] = true;
            grid[0, 0] = true;
            bool[,] result = GameOfLife.NextGen(grid);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2TrueAroundAndTrueMiddle()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected1 = new bool[3, 3];
            bool[,] expected2 = new bool[3, 3];
            grid[2, 2] = true;
            grid[0, 0] = true;
            grid[1, 1] = true;
            expected1[1, 1] = true;
            bool[,] result1 = GameOfLife.NextGen(grid);
            Assert.Equal(expected1, result1);
            bool[,] result2 = GameOfLife.NextGen(result1);
            Assert.Equal(expected2, result2);
        }

        [Fact]
        public void TestVerticalLineAndHorizontalLine()
        {
            bool[,] vertical = new bool[3, 3];
            bool[,] horizontal = new bool[3, 3];
            vertical[1, 0] = true;
            vertical[1, 1] = true;
            vertical[1, 2] = true;
            horizontal[0, 1] = true;
            horizontal[1, 1] = true;
            horizontal[2, 1] = true;
            bool[,] result1 = GameOfLife.NextGen(vertical);
            Assert.Equal(horizontal, result1);
            bool[,] result2 = GameOfLife.NextGen(horizontal);
            Assert.Equal(vertical, result2);
        }

        [Fact]
        public void TestSquare()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected = new bool[3, 3];
            grid[0, 0] = true;
            grid[0, 1] = true;
            grid[1, 0] = true;
            grid[1, 1] = true;
            bool[,] result1 = GameOfLife.NextGen(grid);
            Assert.Equal(grid, result1);
            bool[,] result2 = GameOfLife.NextGen(result1);
            Assert.Equal(grid, result2);
        }

        [Fact]
        public void TestToMuchNeighbours()
        {
            bool[,] grid = new bool[3, 3];
            bool[,] expected1 = new bool[3, 3];
            bool[,] expected2 = new bool[3, 3];
            bool[,] expected3 = new bool[3, 3];
            bool[,] expected4 = new bool[3, 3];
            grid[0, 0] = true;
            grid[0, 1] = true;
            grid[0, 2] = true;
            grid[1, 0] = true;
            grid[1, 1] = true;
            grid[1, 2] = true;
            expected1[0, 0] = true;
            expected1[0, 2] = true;
            expected1[2, 1] = true;
            expected1[1, 0] = true;
            expected1[1, 2] = true;
            expected2[1, 0] = true;
            expected2[1, 2] = true;
            expected2[2, 1] = true;
            expected3[1, 1] = true;
            expected3[2, 1] = true;
            bool[,] result1 = GameOfLife.NextGen(grid);
            Assert.Equal(expected1, result1);
            bool[,] result2 = GameOfLife.NextGen(result1);
            Assert.Equal(expected2, result2);
            bool[,] result3 = GameOfLife.NextGen(result2);
            Assert.Equal(expected3, result3);
            bool[,] result4 = GameOfLife.NextGen(result3);
            Assert.Equal(expected4, result4);
        }
    }
}