using System.Collections.Generic;
using Sudoku.Core.Models;

namespace Sudoku.Core.Test
{
    public static class SudokuExamples
    {
        public static List<SudokuNumber> Example = new List<SudokuNumber>
        {
            // Row 1
            new SudokuNumber
            {
                Index = (0, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (0, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (0, 2),
                Number = 3
            },
            new SudokuNumber
            {
                Index = (0, 3),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (0, 4),
                Number = 2
            },
            new SudokuNumber
            {
                Index = (0, 5),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (0, 6),
                Number = 6
            },
            new SudokuNumber
            {
                Index = (0, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (0, 8),
                Number = 0
            },
            // Row 2
            new SudokuNumber
            {
                Index = (1, 0),
                Number = 9
            },
            new SudokuNumber
            {
                Index = (1, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (1, 2),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (1, 3),
                Number = 3
            },
            new SudokuNumber
            {
                Index = (1, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (1, 5),
                Number = 5
            },
            new SudokuNumber
            {
                Index = (1, 6),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (1, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (1, 8),
                Number = 1
            },
            // Row 3
            new SudokuNumber
            {
                Index = (2, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (2, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (2, 2),
                Number = 1
            },
            new SudokuNumber
            {
                Index = (2, 3),
                Number = 8
            },
            new SudokuNumber
            {
                Index = (2, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (2, 5),
                Number = 6
            },
            new SudokuNumber
            {
                Index = (2, 6),
                Number = 4
            },
            new SudokuNumber
            {
                Index = (2, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (2, 8),
                Number = 0
            },
            // Row 4
            new SudokuNumber
            {
                Index = (3, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (3, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (3, 2),
                Number = 8
            },
            new SudokuNumber
            {
                Index = (3, 3),
                Number = 1
            },
            new SudokuNumber
            {
                Index = (3, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (3, 5),
                Number = 2
            },
            new SudokuNumber
            {
                Index = (3, 6),
                Number = 9
            },
            new SudokuNumber
            {
                Index = (3, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (3, 8),
                Number = 0
            },
            // Row 5
            new SudokuNumber
            {
                Index = (4, 0),
                Number = 7
            },
            new SudokuNumber
            {
                Index = (4, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 2),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 3),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 5),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 6),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (4, 8),
                Number = 8
            },
            // Row 6
            new SudokuNumber
            {
                Index = (5, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (5, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (5, 2),
                Number = 6
            },
            new SudokuNumber
            {
                Index = (5, 3),
                Number = 7
            },
            new SudokuNumber
            {
                Index = (5, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (5, 5),
                Number = 8
            },
            new SudokuNumber
            {
                Index = (5, 6),
                Number = 2
            },
            new SudokuNumber
            {
                Index = (5, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (5, 8),
                Number = 0
            },
            // Row 7
            new SudokuNumber
            {
                Index = (6, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (6, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (6, 2),
                Number = 2
            },
            new SudokuNumber
            {
                Index = (6, 3),
                Number = 6
            },
            new SudokuNumber
            {
                Index = (6, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (6, 5),
                Number = 9
            },
            new SudokuNumber
            {
                Index = (6, 6),
                Number = 5
            },
            new SudokuNumber
            {
                Index = (6, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (6, 8),
                Number = 0
            },
            // Row 8
            new SudokuNumber
            {
                Index = (7, 0),
                Number = 8
            },
            new SudokuNumber
            {
                Index = (7, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (7, 2),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (7, 3),
                Number = 2
            },
            new SudokuNumber
            {
                Index = (7, 4),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (7, 5),
                Number = 3
            },
            new SudokuNumber
            {
                Index = (7, 6),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (7, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (7, 8),
                Number = 9
            },
            // Row 9
            new SudokuNumber
            {
                Index = (8, 0),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (8, 1),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (8, 2),
                Number = 5
            },
            new SudokuNumber
            {
                Index = (8, 3),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (8, 4),
                Number = 1
            },
            new SudokuNumber
            {
                Index = (8, 5),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (8, 6),
                Number = 3
            },
            new SudokuNumber
            {
                Index = (8, 7),
                Number = 0
            },
            new SudokuNumber
            {
                Index = (8, 8),
                Number = 0
            },
        };
    }
}