using Sudoku.Core.Models;
using System.Linq;
using Xunit;

namespace Sudoku.Core.Test
{
    public class SudokuFileReaderTests
    {
        private const string ExampleSudokuFile = "SudokuInputFiles/sudoku_example_single.txt";

        [Fact]
        public void ReadFile_GivenSingleSudokuInput_ReturnsSudokuObject()
        {
            var sudokuFileReader = new SudokuFileReader(ExampleSudokuFile);
            var expectedNumbers = SudokuExamples.Example;

            NumberGrid numberGrid = sudokuFileReader.ReadSudoku();

            Assert.True(expectedNumbers.SequenceEqual(numberGrid.Numbers));
        }
    }
}
