using System;
using System.Collections.Generic;
using System.Linq;
using Sudoku.Core.Models;

namespace Sudoku.Core
{
    public class NumberGrid
    {
        public List<SudokuNumber> Numbers { get; set; }
        public IEnumerable<HashSet<SudokuNumber>> Squares => CreateSquareSets();
        public IEnumerable<HashSet<SudokuNumber>> Rows => CreateSudokuSets(CreateRowSet);
        public IEnumerable<HashSet<SudokuNumber>> Columns => CreateSudokuSets(CreateColumnSet);

        public NumberGrid(IEnumerable<SudokuNumber> numbers)
        {
            Numbers = numbers.ToList();
        }

        public IEnumerable<HashSet<SudokuNumber>> CreateSudokuSets(Func<IEnumerable<SudokuNumber>, int, HashSet<SudokuNumber>> selectorFunction)
        {
            var sudokuSets = new List<HashSet<SudokuNumber>>();
            for (var i = 0; i < 9; i++)
            {
                var sudokuSet = selectorFunction(Numbers, i);
                sudokuSets.Add(sudokuSet);
            }

            return sudokuSets;
        }

        public IEnumerable<HashSet<SudokuNumber>> CreateSquareSets()
        {
            var sudokuSets = new List<HashSet<SudokuNumber>>();

            for (var i = 0; i < 9; i += 3)
            {
                for (var j = 0; j < 9; j += 3)
                {
                    var sudokuSet = Numbers.Where(n =>
                            (n.Row >= i) && (n.Row < i + 3) && (n.Column >= j) && (n.Column < j + 3))
                        .ToHashSet();
                    sudokuSets.Add(sudokuSet);
                }
            }

            return sudokuSets;
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
