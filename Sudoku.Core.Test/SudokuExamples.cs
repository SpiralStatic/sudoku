﻿namespace Sudoku.Core.Test
{
    public static class SudokuExamples
    {
        public static SudokuPuzzle Simple = new SudokuPuzzle(new NumberGrid(new byte[,]
        {
            {
                0, 0, 3, 0, 2, 0, 6, 0, 0
            },
            {
                9, 0, 0, 3, 0, 5, 0, 0, 1
            },
            {
                0, 0, 1, 8, 0, 6, 4, 0, 0
            },
            {
                0, 0, 8, 1, 0, 2, 9, 0, 0
            },
            {
                7, 0, 0, 0, 0, 0, 0, 0, 8
            },
            {
                0, 0, 6, 7, 0, 8, 2, 0, 0
            },
            {
                0, 0, 2, 6, 0, 9, 5 ,0 ,0
            },
            {
                8, 0, 0, 2, 0, 3, 0, 0, 9
            },
            {
                0, 0, 5, 0, 1, 0, 3, 0 ,0
            }
        }), "Simple");

        public static SudokuPuzzle Difficult = new SudokuPuzzle(new NumberGrid(new byte[,]
        {
            {
                    3, 0, 0, 2, 0, 0, 0, 0, 0
            },
            {
                    0, 0, 0, 1, 0, 7, 0, 0, 0
            },
            {
                    7, 0, 6, 0, 3, 0, 5, 0, 0
            },
            {
                    0, 7, 0, 0, 0, 9, 0, 8 ,0
            },
            {
                    9, 0, 0, 0, 2, 0, 0, 0, 4
            },
            {
                    0, 1, 0, 8, 0, 0, 0, 5, 0
            },
            {
                    0, 0, 9, 0, 4, 0, 3, 0, 1
            },
            {
                    0, 0, 0, 7, 0, 2, 0, 0, 0
            },
            {
                    0, 0, 0, 0, 0, 8, 0, 0, 6
            }
        }), "Difficult");
    }
}