using System.Data.HashFunction.xxHash;
using System.Linq;

namespace Sudoku.Core
{
    public class SudokuPuzzle
    {
        public static readonly IxxHash _xxHashFactory = xxHashFactory.Instance.Create();
        public NumberGrid Grid { get; set; }
        public string Name { get; }

        public SudokuPuzzle(NumberGrid numberGrid, string name)
        {
            Grid = numberGrid;
            Name = !string.IsNullOrEmpty(name) ?  name : _xxHashFactory.ComputeHash(numberGrid.Rows.Values.SelectMany(n => n).ToArray()).AsHexString();
        }
    }
}
