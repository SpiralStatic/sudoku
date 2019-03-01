using System.Collections.Generic;

namespace Sudoku.Core.Models
{
    public class NumberGrid
    {
        public List<SudokuNumber> Numbers { get; }

        public NumberGrid(List<SudokuNumber> numbers)
        {
            Numbers = numbers;
        }
    }
}
