using System.Collections.Generic;

namespace Sudoku.Core
{
    public class NumberGrid
    {
        public byte[,] Numbers { get; set; }
        public Dictionary<(byte, byte), List<byte>> Squares => CreateSquareSets();
        public Dictionary<byte, List<byte>> Rows => CreateRowSets();
        public Dictionary<byte, List<byte>> Columns => CreateColumnSets();

        public NumberGrid(byte[,] numbers)
        {
            Numbers = numbers;
        }

        public Dictionary<(byte, byte), List<byte>> CreateSquareSets()
        {
            var sudokuSets = new Dictionary<(byte, byte), List<byte>>();

            for (byte rowSet = 0; rowSet < 9; rowSet += 3)
            {
                for (byte columnSet = 0; columnSet < 9; columnSet += 3)
                {
                    var rowIndex = (byte)(rowSet / 3);
                    var columnIndex = (byte)(columnSet / 3); ;
                    sudokuSets.Add((rowIndex, columnIndex), new List<byte>
                    {
                        Numbers[rowSet, columnSet],
                        Numbers[rowSet, columnSet + 1],
                        Numbers[rowSet, columnSet + 2],
                        Numbers[rowSet + 1, columnSet],
                        Numbers[rowSet + 1, columnSet + 1],
                        Numbers[rowSet + 1, columnSet + 2],
                        Numbers[rowSet + 2, columnSet],
                        Numbers[rowSet + 2, columnSet + 1],
                        Numbers[rowSet + 2, columnSet +2]
                    });
                }
            }

            return sudokuSets;
        }

        public Dictionary<byte, List<byte>> CreateRowSets()
        {
            var rowSets = new Dictionary<byte, List<byte>>();
            for (byte row = 0; row < 9; row++)
            {
                var rowSet = new List<byte>();

                for (var column = 0; column < 9; column++)
                {
                    rowSet.Add(Numbers[row, column]);
                }

                rowSets.Add(row, rowSet);
            }

            return rowSets;
        }

        public Dictionary<byte, List<byte>> CreateColumnSets()
        {
            var columnSets = new Dictionary<byte, List<byte>>();
            for (byte column = 0; column < 9; column++)
            {
                var columnSet = new List<byte>();

                for (var row = 0; row < 9; row++)
                {
                    columnSet.Add(Numbers[row, column]);
                }

                columnSets.Add(column, columnSet);
            }

            return columnSets;
        }
    }
}
