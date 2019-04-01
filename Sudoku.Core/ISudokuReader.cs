using System.Collections.Generic;
using System.IO;

namespace Sudoku.Core
{
    public interface ISudokuReader
    {
        SudokuPuzzle ReadSudoku(Stream stream);

        IEnumerable<SudokuPuzzle> ReadSudokus(Stream stream);
    }
}
