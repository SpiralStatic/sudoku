using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Sudoku.ConsoleApp.Test
{
    public class ProgramTests
    {
        private readonly StringWriter output;

        public ProgramTests()
        {
            output = new StringWriter();
            Console.SetOut(output);
        }

        [Fact]
        public void Main_GivenNoArguments_ReturnsNoArgumentsExitCode()
        {
            var expectedExitCode = ExitCode.NoArguments;

            Assert.Equal((int)expectedExitCode, Program.Main(new string[0]));
        }

        [Fact]
        public void Main_GivenInvalidPuzzlePath_ReturnsPuzzleDoesNotExistExitCode()
        {
            var expectedExitCode = (int)ExitCode.PuzzleDoesNotExist;

            Assert.Equal(expectedExitCode, Program.Main(new[] { "non_existing_puzzle.txt" }));
        }

        [Fact]
        public void Main_GivenInvalidPuzzlePath_LogsPuzzleDoesNotExistExitCode()
        {
            var expectedExitCode = ExitCode.PuzzleDoesNotExist.ToString();

            Program.Main(new[] { "non_existing_puzzle.txt" });
            Assert.Contains(expectedExitCode, output.ToString());
        }

        //[Fact]
        //public void Main_GivenInvalidSudoku_ReturnsFailedToSolvePuzzleExitCode()
        //{
        //    var InvalidSudokuFile = "SudokuInputFiles/sudoku_example_invalid.txt";
        //    var expectedExitCode = (int)ExitCode.FailedToSolvePuzzle;

        //    Assert.Equal(expectedExitCode, Program.Main(new[] { InvalidSudokuFile }));
        //}

        [Fact]
        public void Main_GivenValidSudoku_ReturnsSuccessExitCode()
        {
            var ValidSudokuFile = "SudokuInputFiles/sudoku_example_single.txt";
            var expectedExitCode = (int)ExitCode.Success;

            Assert.Equal(expectedExitCode, Program.Main(new[] { ValidSudokuFile }));
        }

        [Fact]
        public void Main_GivenMultipleValidSudoku_ReturnsSuccessExitCode()
        {
            var ValidSudokuFile = "SudokuInputFiles/sudoku_example_single.txt";
            var expectedExitCode = (int)ExitCode.Success;

            Assert.Equal(expectedExitCode, Program.Main(new[] { ValidSudokuFile, ValidSudokuFile }));
        }
    }
}
