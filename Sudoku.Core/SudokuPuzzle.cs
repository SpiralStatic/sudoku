using Sudoku.Core.Models;

namespace Sudoku.Core
{
    public class SudokuPuzzle
    {
        private NumberGrid _grid;

        public SudokuPuzzle(ISudokuReader sudokuReader)
        {
            _grid = sudokuReader.ReadSudoku();
        }
    }
}
