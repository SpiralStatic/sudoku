using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.Extensions.Logging;
using Sudoku.Core.Models;

namespace Sudoku.Core.Extensions
{
    public static class LoggerExtensions
    {
        public static void LogSudoku(this ILogger logger, IEnumerable<SudokuNumber> numbers, SudokuNumber sudokuNumber, int newNumber)
        {
            var numbersArray = numbers.ToImmutableArray();

            logger.LogInformation($"SudokuNumber{sudokuNumber.Index}: {sudokuNumber.Number} => {newNumber}");
            
            for (var i = 0; i < numbersArray.Count(); i += 9)
            {
                var rowIndex = i;
                var row = numbersArray.Where(n => n.Row == rowIndex / 9).Select(n => n.Number);
                logger.LogInformation(string.Join("", row));
            }

            logger.LogInformation(Environment.NewLine);
        }
    }
}
