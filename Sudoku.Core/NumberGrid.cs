using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Core.Models
{
    public class NumberGrid
    {
        public IEnumerable<SudokuNumber> Numbers { get; }
        public IEnumerable<HashSet<SudokuNumber>> Squares { get; }
        public IEnumerable<HashSet<SudokuNumber>> Rows { get; }
        public IEnumerable<HashSet<SudokuNumber>> Columns { get; }

        public NumberGrid(IEnumerable<SudokuNumber> numbers)
        {
            Numbers = numbers;
            Squares = CreateSudokuSets(CreateSquareSet, Numbers);
            Rows = CreateSudokuSets(CreateRowSet, Numbers);
            Columns = CreateSudokuSets(CreateColumnSet, Numbers);
        }

        public IEnumerable<HashSet<SudokuNumber>> CreateSudokuSets(Func<IEnumerable<SudokuNumber>, int, HashSet<SudokuNumber>> selectorFunction, IEnumerable<SudokuNumber> numbers)
        {
            var sudokuSets = new List<HashSet<SudokuNumber>>();
            for (var i = 0; i < 9; i += 3)
            {
                var sudokuSet = selectorFunction(numbers, i);
                sudokuSets.Add(sudokuSet);
            }

            return sudokuSets;
        }

        public HashSet<SudokuNumber> CreateSquareSet(IEnumerable<SudokuNumber> numbers, int index)
        {
            return numbers.Where(n => (n.Row >= index) && (n.Row < index + 3) && (n.Column >= index) && (n.Column < index + 3))
                .ToHashSet();
        }

        public HashSet<SudokuNumber> CreateRowSet(IEnumerable<SudokuNumber> numbers, int index)
        {
             return numbers.Where(n => n.Row == index)
                 .ToHashSet();
        }

        public HashSet<SudokuNumber> CreateColumnSet(IEnumerable<SudokuNumber> numbers, int index)
        {
            return numbers.Where(n => n.Column == index)
                .ToHashSet();
        }
    }
}
