using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Sudoku.Core.Test
{
    public class SudokuFileReaderTests
    {
        private const string SingleSudokuFile = "SudokuInputFiles/sudoku_example_single.txt";
        private const string SudokuListFile = "SudokuInputFiles/sudoku_example_list.txt";

        [Fact]
        public void ReadFile_GivenSingleSudokuInput_ReturnsCorrectSudokuPuzzle()
        {   
            var expectedNumbers = SudokuExamples.Simple.Grid.Numbers;

            var sudokuFileReader = new SudokuFileReader();

            SudokuPuzzle puzzle = sudokuFileReader.ReadSudoku(File.OpenRead(SingleSudokuFile));

            Assert.Equal(expectedNumbers, puzzle.Grid.Numbers);
        }

        [Fact]
        public void ReadFile_GivenListOfSudokuInput_ReturnsSudokuPuzzleList()
        {
            var expectedNumberOfPuzzles = 50;
            var sudokuFileReader = new SudokuFileReader();

            List<SudokuPuzzle> puzzles = sudokuFileReader.ReadSudokus(File.OpenRead(SudokuListFile)).ToList();

            Assert.Equal(expectedNumberOfPuzzles, puzzles.Count);
        }

        [Fact]
        public void ReadFile_GivenListOfSudokuInput_ReturnsCorrectLastSudokuPuzzle()
        {
            var expectedNumbers = SudokuExamples.Difficult.Grid.Numbers;

            var sudokuFileReader = new SudokuFileReader();

            List<SudokuPuzzle> puzzles = sudokuFileReader.ReadSudokus(File.OpenRead(SudokuListFile)).ToList();

            Assert.Equal(expectedNumbers, puzzles.Last().Grid.Numbers);
        }
    }
}
