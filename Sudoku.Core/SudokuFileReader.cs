using System.IO;
using System.Linq;

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
            var numberGrid = new byte[9,9];

            var lines = File.ReadAllLines(_filePath);
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var numbers = line.ToCharArray()
                    .Select(n => byte.Parse(n.ToString()))
                    .ToArray();

                for (var j = 0; j < numbers[i]; j++)
                {
                    numberGrid[i, j] = numbers[j];
                }
            }

            return new NumberGrid(numberGrid);
        }
    }
}
