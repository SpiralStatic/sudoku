using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Sudoku.Core.Models;

namespace Sudoku.Core
{
    public class SudokuFileReader : ISudokuReader
    {
        private readonly string _filePath;

        public SudokuFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public NumberGrid ReadSudoku()
        {
            var numbers = File.ReadLines(_filePath)
                .SkipWhile(line => !Regex.IsMatch(line, "\\d{9}"))
                .Select((line, rowIndex) => line.ToCharArray()
                    .Select((number, columnIndex) => new SudokuNumber
                    {
                        Index = (rowIndex, columnIndex),
                        Number = byte.Parse(number.ToString())
                    })
                )
                .Aggregate(new List<SudokuNumber>(), (acc, row) =>
                {
                    acc.AddRange(row);

                    return acc;
                });

            return new NumberGrid(numbers);
        }
    }
}
