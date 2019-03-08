using Sudoku.Core.Models;
using System.Linq;
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
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);

            var sudokuSolver = new SudokuSolver(numberGrid, _logger.Object);
            sudokuSolver.Solve(0);

            foreach (SudokuNumber sudokuNumber in numberGrid.Numbers)
            {
                Assert.NotEqual(0, sudokuNumber.Number);
            }
        }

        [Fact]
        public void TrySolveNumber_GivenNumberWithOnePossibleResults_ReturnsCorrectResult()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            const int expectedNewNumber = 0;

            var sudokuSolver = new SudokuSolver(numberGrid, _logger.Object);
            SudokuNumber firstSudokuNumber = numberGrid.Numbers.First();
            sudokuSolver.TrySolveNumber(firstSudokuNumber, out var solvedNumber);

            Assert.Equal(expectedNewNumber, solvedNumber);
        }

        [Fact]
        public void TrySolveNumber_GivenNumberWithTwoPossibleResults_Returns0()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            const int expectedNewNumber = 0;

            var sudokuSolver = new SudokuSolver(numberGrid, _logger.Object);
            SudokuNumber firstSudokuNumber = numberGrid.Numbers.First();
            sudokuSolver.TrySolveNumber(firstSudokuNumber, out var solvedNumber);

            Assert.Equal(expectedNewNumber, solvedNumber);
        }
    }
}
