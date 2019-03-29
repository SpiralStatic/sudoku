using System.Data.HashFunction.xxHash;
using System.Linq;

namespace Sudoku.Core
{
    public class SudokuPuzzle
    {
        public static readonly IxxHash _xxHashFactory = xxHashFactory.Instance.Create();
        public NumberGrid Grid { get; set; }
        public string Name { get; }

        public SudokuPuzzle(NumberGrid numberGrid)
        {
            Grid = numberGrid;
            Name = _xxHashFactory.ComputeHash(numberGrid.Rows.Values.SelectMany(n => n).ToArray()).AsHexString();
        }
    }
}
