using System.IO;
using Sudoku.Core.Models;

namespace Sudoku.Core
{
    public interface ISudokuReader
    {
        NumberGrid ReadSudoku();
    }
}
