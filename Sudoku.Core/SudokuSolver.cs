using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Sudoku.Core.Extensions;
using Sudoku.Core.Models;

namespace Sudoku.Core
{
    public class SudokuSolver
    {
        private readonly NumberGrid _numberGrid;
        private readonly byte[] _possibleNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly ILogger _logger;

        public SudokuSolver(NumberGrid numberGrid, ILogger<SudokuSolver> logger)
        {
            _numberGrid = numberGrid;
            _logger = logger;
        }

        public void Solve(int position)
        {
            SudokuNumber nextSudokuNumber = _numberGrid.Numbers.ElementAt(position);
            if (nextSudokuNumber.Number == 0)
            {
                var solved = TrySolveNumber(nextSudokuNumber, out var newNumber);
                if (solved)
                {
                    _logger.LogSudoku(_numberGrid.Numbers, nextSudokuNumber, newNumber);

                    nextSudokuNumber.Number = newNumber;
                }
            }

            if(position < _numberGrid.Numbers.Count - 1)
            {
                Solve(position + 1);
            }
            else
            {
                var firstNotSolvedIndex = _numberGrid.Numbers.TakeWhile(n => n.Number != 0).Count();
                if (firstNotSolvedIndex != _numberGrid.Numbers.Count)
                {
                    _logger.LogInformation($"Resolving from: SudokuNumber{_numberGrid.Numbers[firstNotSolvedIndex].Index}");
                    Solve(firstNotSolvedIndex);
                }
            }
        }

        public bool TrySolveNumber(SudokuNumber sudokuNumber, out byte result)
        {
            var currentRowNumbers = _numberGrid.Rows.ElementAt(sudokuNumber.Row)
                .Where(n => n.Number != 0)
                .Select(n => n.Number);
            var currentColumnNumbers = _numberGrid.Columns.ElementAt(sudokuNumber.Column)
                .Where(n => n.Number != 0)
                .Select(n => n.Number);

            var squareRow = Math.Ceiling((sudokuNumber.Row + 1.00) / 3.00) - 1;
            var squareColumn = Math.Ceiling((sudokuNumber.Column + 1.00) / 3.00) - 1;
            var currentSquare = squareRow + squareColumn;
            var currentSquareNumbers = _numberGrid.Squares.ElementAt((int)currentSquare)
                .Where(n => n.Number != 0)
                .Select(n => n.Number);

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
    }
}
