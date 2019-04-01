using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Sudoku.Core.Test
{
    public class SudokuSolverTests
    {
        private readonly Mock<ILogger<SudokuSolver>> _logger;

        public SudokuSolverTests()
        {
            _logger = new Mock<ILogger<SudokuSolver>>();
        }
        
        [Fact]
        public void TrySolve_GivenNumberGrid_ProducesFinishedGrid()
        {
            var puzzle = SudokuExamples.Simple;

            var sudokuSolver = new SudokuSolver(_logger.Object);
            sudokuSolver.Solve(puzzle);

            foreach (var number in puzzle.Grid.Numbers)
            {
                Assert.NotEqual(0, number);
            }
        }

        [Fact]
        public void TrySolveNumber_GivenNumberWithOnePossibleResults_ReturnsCorrectResult()
        {
            var grid = SudokuExamples.Simple.Grid;
            const int expectedNewNumber = 0;

            var sudokuSolver = new SudokuSolver(_logger.Object);
            sudokuSolver.TrySolveNumber(grid, 0, 0, out var solvedNumber);

            Assert.Equal(expectedNewNumber, solvedNumber);
        }

        [Fact]
        public void TrySolveNumber_GivenNumberWithTwoPossibleResults_Returns0()
        {
            var grid = SudokuExamples.Simple.Grid;
            const int expectedNewNumber = 0;

            var sudokuSolver = new SudokuSolver(_logger.Object);
            sudokuSolver.TrySolveNumber(grid, 0, 0, out var solvedNumber);

            Assert.Equal(expectedNewNumber, solvedNumber);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(3, 1)]
        [InlineData(4, 1)]
        [InlineData(5, 1)]
        [InlineData(6, 2)]
        [InlineData(7, 2)]
        [InlineData(8, 2)]
        public void Scale_GivenNumber_ReturnScaledNumber(int number, int expectedScaledNumber)
        {
            var min = 0;
            var max = 8;
            var minScale = 0;
            var maxScale = 2;

            var scaledNumber = SudokuSolver.Scale(number, min, max, minScale, maxScale);

            Assert.Equal(expectedScaledNumber, scaledNumber);
        }
    }
}
