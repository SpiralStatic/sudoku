using System.IO;
using Xunit;

namespace Sudoku.Core.Test
{
    public class SudokuFileReaderTests
    {
        private const string ExampleSudokuFile = "SudokuInputFiles/sudoku_example_single.txt";

        [Fact]
        public void ReadFile_GivenSingleSudokuInput_ReturnsSudokuObject()
        {   
            var expectedNumbers = SudokuExamples.Example.Grid.Numbers;

            var sudokuFileReader = new SudokuFileReader();

            SudokuPuzzle puzzle = sudokuFileReader.ReadSudoku(File.OpenRead(ExampleSudokuFile));

            Assert.Equal(expectedNumbers, puzzle.Grid.Numbers);
        }
    }
}
