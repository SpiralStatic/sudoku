using Sudoku.Core.Models;
using System.Collections.Generic;
using Xunit;

namespace Sudoku.Core.Test
{
    public class NumberGridTests
    {
        [Fact]
        public void CreateSquareSet_GivenNumbersAndIndexOf1_ReturnsFirstSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (0, 0), Number = 0},
                new SudokuNumber {Index = (0, 1), Number = 0},
                new SudokuNumber {Index = (0, 2), Number = 3},
                new SudokuNumber {Index = (1, 0), Number = 9},
                new SudokuNumber {Index = (1, 1), Number = 0},
                new SudokuNumber {Index = (1, 2), Number = 0},
                new SudokuNumber {Index = (2, 0), Number = 0},
                new SudokuNumber {Index = (2, 1), Number = 0},
                new SudokuNumber {Index = (2, 2), Number = 1}
            });

            var firstSquareSet = numberGrid.CreateSquareSet(numbers, 0);
    
            Assert.True(expectedSet.SetEquals(firstSquareSet));
        }

        [Fact]
        public void CreateRowSet_GivenNumbersAndIndexOf1_ReturnsFirstSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (0, 0), Number = 0},
                new SudokuNumber {Index = (0, 1), Number = 0},
                new SudokuNumber {Index = (0, 2), Number = 3},
                new SudokuNumber {Index = (0, 3), Number = 0},
                new SudokuNumber {Index = (0, 4), Number = 2},
                new SudokuNumber {Index = (0, 5), Number = 0},
                new SudokuNumber {Index = (0, 6), Number = 6},
                new SudokuNumber {Index = (0, 7), Number = 0},
                new SudokuNumber {Index = (0, 8), Number = 0}
            });

            var firstRowSet = numberGrid.CreateRowSet(numbers, 0);

            Assert.True(expectedSet.SetEquals(firstRowSet));
        }

        [Fact]
        public void CreateColumnSet_GivenNumbersAndIndexOf1_ReturnsFirstSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (0, 0), Number = 0},
                new SudokuNumber {Index = (1, 0), Number = 9},
                new SudokuNumber {Index = (2, 0), Number = 0},
                new SudokuNumber {Index = (3, 0), Number = 0},
                new SudokuNumber {Index = (4, 0), Number = 7},
                new SudokuNumber {Index = (5, 0), Number = 0},
                new SudokuNumber {Index = (6, 0), Number = 0},
                new SudokuNumber {Index = (7, 0), Number = 8},
                new SudokuNumber {Index = (8, 0), Number = 0}
            });

            var firstColumnSet = numberGrid.CreateColumnSet(numbers, 0);

            Assert.True(expectedSet.SetEquals(firstColumnSet));
        }
    }
}
