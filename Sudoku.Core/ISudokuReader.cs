using System.IO;

namespace Sudoku.Core
{
    public interface ISudokuReader
    {
        SudokuPuzzle ReadSudoku(Stream stream);
    }
}
