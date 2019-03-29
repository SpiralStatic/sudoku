using System.Collections.Generic;
using Xunit;

namespace Sudoku.Core.Test
{
    public class NumberGridTests
    {
        [Fact]
        public void CreateSquareSets_GivenSquareIndex_ReturnsFirstSquareSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 0, 3, 9, 0, 0, 0, 0, 1
            });

            var squareSets = numberGrid.CreateSquareSets();
            squareSets.TryGetValue((0, 0), out var firstSquareSet);

            Assert.NotNull(firstSquareSet);
            Assert.True(expectedSet.SetEquals(firstSquareSet));
        }

        [Fact]
        public void CreateSquareSets_GivenSquareIndex_ReturnsSecondSquareSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 2, 0, 3, 0, 5, 8, 0, 6
            });

            var squareSets = numberGrid.CreateSquareSets();
            squareSets.TryGetValue((0, 1), out var secondSquareSet);

            Assert.NotNull(secondSquareSet);
            Assert.True(expectedSet.SetEquals(secondSquareSet));
        }

        [Fact]
        public void CreateSquareSets_GivenSquareIndex_ReturnsLastSquareSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                5, 0, 0, 0, 0, 9, 3, 0, 0
            });

            var squareSets = numberGrid.CreateSquareSets();
            squareSets.TryGetValue((2, 2), out var lastSquareSet);

            Assert.NotNull(lastSquareSet);
            Assert.True(expectedSet.SetEquals(lastSquareSet));
        }

        [Fact]
        public void CreateRowSets_GivenRowIndex_ReturnsFirstRowSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 0, 3, 0, 2, 0, 6, 0, 0
            });

            var rowSets = numberGrid.CreateRowSets();
            rowSets.TryGetValue(0, out var firstRowSet);

            Assert.NotNull(firstRowSet);
            Assert.True(expectedSet.SetEquals(firstRowSet));
        }

        [Fact]
        public void CreateRowSets_GivenRowIndex_ReturnsSecondRowSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                9, 0, 0, 3, 0, 5, 0, 0, 1
            });

            var rowSets = numberGrid.CreateRowSets();
            rowSets.TryGetValue(1, out var secondRowSet);

            Assert.NotNull(secondRowSet);
            Assert.True(expectedSet.SetEquals(secondRowSet));
        }

        [Fact]
        public void CreateRowSets_GivenRowIndex_ReturnsLastRowSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 0, 5, 0, 1, 0, 3, 0, 0
            });

            var rowSets = numberGrid.CreateRowSets();
            rowSets.TryGetValue(8, out var lastRowSet);

            Assert.NotNull(lastRowSet);
            Assert.True(expectedSet.SetEquals(lastRowSet));
        }

        [Fact]
        public void CreateColumnSets_GivenRowIndex_ReturnsFirstColumnSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 9, 0, 0, 7, 0, 0, 8, 0
            });

            var columnSets = numberGrid.CreateColumnSets();
            columnSets.TryGetValue(0, out var firstColumnSet);

            Assert.NotNull(firstColumnSet);
            Assert.True(expectedSet.SetEquals(firstColumnSet));
        }

        [Fact]
        public void CreateColumnSets_GivenRowIndex_ReturnsSecondColumnSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0
            });

            var columnSets = numberGrid.CreateColumnSets();
            columnSets.TryGetValue(1, out var secondColumnSet);

            Assert.True(expectedSet.SetEquals(secondColumnSet));
        }

        [Fact]
        public void CreateColumnSets_GivenRowIndex_ReturnslastColumnSet()
        {
            var numbers = SudokuExamples.Example.Grid.Numbers;
            var numberGrid = new NumberGrid(numbers);
            var expectedSet = new HashSet<byte>(new List<byte>
            {
                0, 1, 0, 0, 8, 0, 0, 9, 0
            });

            var columnSets = numberGrid.CreateColumnSets();
            columnSets.TryGetValue(8, out var lastColumnSet);

            Assert.True(expectedSet.SetEquals(lastColumnSet));
        }
    }
}
