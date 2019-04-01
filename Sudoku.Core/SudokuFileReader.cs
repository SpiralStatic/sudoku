using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sudoku.Core
{
    public class SudokuFileReader : ISudokuReader
    {
        public SudokuPuzzle ReadSudoku(Stream stream)
        {
            byte[,] numberGrid;
            using (var streamReader = new StreamReader(stream))
            {
                numberGrid = CreateGrid(streamReader);
            }

            return new SudokuPuzzle(new NumberGrid(numberGrid), null);
        }

        public IEnumerable<SudokuPuzzle> ReadSudokus(Stream stream)
        {
            var sudokuPuzzles = new List<SudokuPuzzle>();

            using (var streamReader = new StreamReader(stream))
            {
                string puzzleSeperator;
                while((puzzleSeperator = streamReader.ReadLine()) != null)
                {
                    if (!Regex.IsMatch(puzzleSeperator, @"\d{9}"))
                    {
                        byte[,] numberGrid = CreateGrid(streamReader);
                        sudokuPuzzles.Add(new SudokuPuzzle(new NumberGrid(numberGrid), puzzleSeperator));
                    }
                }    
            }

            return sudokuPuzzles;
        }

        private static byte[,] CreateGrid(StreamReader streamReader)
        {
            var lineIndex = 0;

            var numberGrid = new byte[9, 9];

            while (lineIndex < 9)
            {
                var line = streamReader.ReadLine();
                var numbers = line.ToCharArray()
                   .Select(n => byte.Parse(n.ToString()))
                   .ToArray();

                for (var j = 0; j < numbers.Length; j++)
                {
                    numberGrid[lineIndex, j] = numbers[j];
                }

                lineIndex++;
            }

            return numberGrid;
        }
    }
}