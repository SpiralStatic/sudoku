using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Sudoku.Core.Extensions
{
    public static class LoggerExtensions
    {
        public static void LogSudoku(this ILogger logger, IEnumerable<byte> rows)
        {
            var rowsArray = rows.ToImmutableArray();

            for (var i = 0; i < rowsArray.Count(); i += 9)
            {
                var row = rowsArray.Skip(i).Take(9);
                logger.LogInformation(string.Join("", row));
            }

            logger.LogInformation(Environment.NewLine);
        }
    }
}
