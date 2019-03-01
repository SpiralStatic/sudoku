using System;

namespace Sudoku.Core.Models
{
    public class SudokuNumber : IEquatable<SudokuNumber>
    {
        public (int, int) Index { get; set; }
        public int Number { get; set; }

        public int Row => Index.Item1;
        public int Column => Index.Item2;

        public override bool Equals(object obj)
        {
            return Equals(obj as SudokuNumber);
        }

        public bool Equals(SudokuNumber other)
        {
            return other != null &&
                   Number == other.Number &&
                   Row == other.Row &&
                   Column == other.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number, Row, Column);
        }
    }
}
