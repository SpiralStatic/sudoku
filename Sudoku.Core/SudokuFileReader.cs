using System.IO;
using System.Linq;

namespace Sudoku.Core
{
    public class SudokuFileReader : ISudokuReader
    {
        public SudokuPuzzle ReadSudoku(Stream stream)
        {
            var numberGrid = new byte[9, 9];

            using (var streamReader = new StreamReader(stream))
            {
                var lineIndex = 0;

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var numbers = line.ToCharArray()
                        .Select(n => byte.Parse(n.ToString()))
                        .ToArray();

                    for (var j = 0; j < numbers.Length; j++)
                    {
                        numberGrid[lineIndex, j] = numbers[j];
                    }

                    lineIndex++;
                }
            }

            return new SudokuPuzzle(new NumberGrid(numberGrid));
        }
    }
}