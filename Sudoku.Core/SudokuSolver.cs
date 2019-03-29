using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Sudoku.Core.Extensions;

namespace Sudoku.Core
{
    public class SudokuSolver
    {
        private readonly byte[] _possibleNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly ILogger _logger;

        public SudokuSolver(ILogger<SudokuSolver> logger)
        {
            _logger = logger;
        }

        public void Solve(SudokuPuzzle puzzle)
        {
            var notSolved = false;
            for (byte row = 0; row < puzzle.Grid.Numbers.GetLength(0); row++)
            for (byte column = 0; column < puzzle.Grid.Numbers.GetLength(1); column++)
            {
                var number = puzzle.Grid.Numbers[row, column];
                if (number == 0)
                {
                    var solved = TrySolveNumber(puzzle.Grid, row, column, out var newNumber);
                    if (solved)
                    {
                        _logger.LogInformation($"Number({row},{column}): {number} => {newNumber}");
                        _logger.LogSudoku(puzzle.Grid.Rows.SelectMany(r => r.Value));

                            puzzle.Grid.Numbers[row, column] = newNumber;
                    }
                    else
                    {
                        notSolved = true;
                    }
                }
            }

            if (notSolved)
            {
                Solve(puzzle);
            }
        }

        public bool TrySolveNumber(NumberGrid grid, byte row, byte column, out byte result)
        {
            grid.Rows.TryGetValue(row, out var rowNumbers);
            var currentRowNumbers =  (rowNumbers ?? throw new IndexOutOfRangeException()).Where(n => n != 0);

            grid.Columns.TryGetValue(column, out var columnNumbers);
            var currentColumnNumbers = (columnNumbers ?? throw new IndexOutOfRangeException()).Where(n => n != 0);

            var squareRow = (byte)Scale(row, 0, 8, 0, 2);
            var squareColumn = (byte)Scale(column, 0, 8, 0, 2);
            grid.Squares.TryGetValue((squareRow, squareColumn), out var squareNumbers);
            var currentSquareNumbers = (squareNumbers ?? throw new IndexOutOfRangeException()).Where(n => n != 0);

            var possibleNumbers = _possibleNumbers.Except(currentRowNumbers)
                .Except(currentColumnNumbers)
                .Except(currentSquareNumbers)
                .ToArray();

            if (possibleNumbers.Length == 1)
            {
                result = possibleNumbers[0];

                return true;
            }

            result = 0;
            return false;
        }

        public static double Scale(int value, int min, int max, int minScale, int maxScale)
        {
            var scaled = minScale + (double)(value - min) / (max - min) * (maxScale - minScale);
            return Math.Round(scaled);
        }
    }
}
