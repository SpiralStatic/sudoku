using Sudoku.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Sudoku.Core.Test
{
    public class NumberGridTests
    {
        [Fact]
        public void CreateSquareSet_GivenNumbers_ReturnsFirstSquareSet()
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

            var firstSquareSet = numberGrid.CreateSquareSets();
    
            Assert.True(expectedSet.SetEquals(firstSquareSet.ElementAt(0)));
        }

        [Fact]
        public void CreateSquareSet_GivenNumbers_ReturnsSecondSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (0, 3), Number = 0},
                new SudokuNumber {Index = (0, 4), Number = 2},
                new SudokuNumber {Index = (0, 5), Number = 0},
                new SudokuNumber {Index = (1, 3), Number = 3},
                new SudokuNumber {Index = (1, 4), Number = 0},
                new SudokuNumber {Index = (1, 5), Number = 5},
                new SudokuNumber {Index = (2, 3), Number = 8},
                new SudokuNumber {Index = (2, 4), Number = 0},
                new SudokuNumber {Index = (2, 5), Number = 6}
            });

            var secondSquareSet = numberGrid.CreateSquareSets();

            Assert.True(expectedSet.SetEquals(secondSquareSet.ElementAt(1)));
        }

        [Fact]
        public void CreateSquareSet_GivenNumbers_ReturnsLastSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (6, 6), Number = 5},
                new SudokuNumber {Index = (6, 7), Number = 0},
                new SudokuNumber {Index = (6, 8), Number = 0},
                new SudokuNumber {Index = (7, 6), Number = 0},
                new SudokuNumber {Index = (7, 7), Number = 0},
                new SudokuNumber {Index = (7, 8), Number = 9},
                new SudokuNumber {Index = (8, 6), Number = 3},
                new SudokuNumber {Index = (8, 7), Number = 0},
                new SudokuNumber {Index = (8, 8), Number = 0}
            });

            var lastSquareSet = numberGrid.CreateSquareSets();

            Assert.True(expectedSet.SetEquals(lastSquareSet.ElementAt(8)));
        }

        [Fact]
        public void CreateRowSet_GivenNumbers_ReturnsFirstSquareSet()
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
        public void CreateRowSet_GivenNumbers_ReturnsSecondSquareSet()
        {
            var numbers = SudokuExamples.Example;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<SudokuNumber>(new List<SudokuNumber>
            {
                new SudokuNumber {Index = (1, 0), Number = 9},
                new SudokuNumber {Index = (1, 1), Number = 0},
                new SudokuNumber {Index = (1, 2), Number = 0},
                new SudokuNumber {Index = (1, 3), Number = 3},
                new SudokuNumber {Index = (1, 4), Number = 0},
                new SudokuNumber {Index = (1, 5), Number = 5},
                new SudokuNumber {Index = (1, 6), Number = 0},
                new SudokuNumber {Index = (1, 7), Number = 0},
                new SudokuNumber {Index = (1, 8), Number = 1}
            });

            var secondRowSet = numberGrid.CreateRowSet(numbers, 1);

            Assert.True(expectedSet.SetEquals(secondRowSet));
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
