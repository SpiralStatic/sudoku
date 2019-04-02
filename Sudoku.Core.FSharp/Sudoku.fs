namespace Sudoku.Core.FSharp

open System.IO

module Sudoku =
    type Number = { x: int; y: int; value: int }
    type SudokuPuzzle = { name: string; numbers: Number list }

    let extractNumbersFromRow row = 
        Seq.toList row |> List.map (fun (c: char) -> System.Globalization.CharUnicodeInfo.GetNumericValue c |> int)

    let createNumber rowIndex row =
        List.mapi (fun colIndex value -> { x=colIndex; y=rowIndex; value=value }) row

    let readSudokuFile (filePath: string) : SudokuPuzzle =
        let rows = File.ReadLines filePath |> Seq.toList
        let rowsWithNumbers = List.map extractNumbersFromRow rows
        let numbers = List.mapi createNumber rowsWithNumbers |> List.fold (fun acc row -> row @ acc) [] |> List.sort
        { name="1"; numbers = numbers}
