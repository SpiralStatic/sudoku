module SudokuTests
    open Xunit
    open Sudoku.Core.FSharp.Sudoku

    [<Fact>]
    let ``readSudokuFile when given valid sudoku input file returns sudoku puzzle`` () =
        let filePath = "SudokuInputFiles/sudoku_example_single.txt"
        let expectedPuzzle = { name = "1"; numbers = [
            { x=0; y=0; value=0; };{ x=0; y=1; value=9; };{ x=0; y=2; value=0; };{ x=0; y=3; value=0; };{ x=0; y=4; value=7; };{ x=0; y=5; value=0; };{ x=0; y=6; value=0; };{ x=0; y=7; value=8; };{ x=0; y=8; value=0; };
            { x=1; y=0; value=0; };{ x=1; y=1; value=0; };{ x=1; y=2; value=0; };{ x=1; y=3; value=0; };{ x=1; y=4; value=0; };{ x=1; y=5; value=0; };{ x=1; y=6; value=0; };{ x=1; y=7; value=0; };{ x=1; y=8; value=0; };
            { x=2; y=0; value=3; };{ x=2; y=1; value=0; };{ x=2; y=2; value=1; };{ x=2; y=3; value=8; };{ x=2; y=4; value=0; };{ x=2; y=5; value=6; };{ x=2; y=6; value=2; };{ x=2; y=7; value=0; };{ x=2; y=8; value=5; };
            { x=3; y=0; value=0; };{ x=3; y=1; value=3; };{ x=3; y=2; value=8; };{ x=3; y=3; value=1; };{ x=3; y=4; value=0; };{ x=3; y=5; value=7; };{ x=3; y=6; value=6; };{ x=3; y=7; value=2; };{ x=3; y=8; value=0; };
            { x=4; y=0; value=2; };{ x=4; y=1; value=0; };{ x=4; y=2; value=0; };{ x=4; y=3; value=0; };{ x=4; y=4; value=0; };{ x=4; y=5; value=0; };{ x=4; y=6; value=0; };{ x=4; y=7; value=0; };{ x=4; y=8; value=1; };
            { x=5; y=0; value=0; };{ x=5; y=1; value=5; };{ x=5; y=2; value=6; };{ x=5; y=3; value=2; };{ x=5; y=4; value=0; };{ x=5; y=5; value=8; };{ x=5; y=6; value=9; };{ x=5; y=7; value=3; };{ x=5; y=8; value=0; };
            { x=6; y=0; value=6; };{ x=6; y=1; value=0; };{ x=6; y=2; value=4; };{ x=6; y=3; value=9; };{ x=6; y=4; value=0; };{ x=6; y=5; value=2; };{ x=6; y=6; value=5; };{ x=6; y=7; value=0; };{ x=6; y=8; value=3; };
            { x=7; y=0; value=0; };{ x=7; y=1; value=0; };{ x=7; y=2; value=0; };{ x=7; y=3; value=0; };{ x=7; y=4; value=0; };{ x=7; y=5; value=0; };{ x=7; y=6; value=0; };{ x=7; y=7; value=0; };{ x=7; y=8; value=0; };
            { x=8; y=0; value=0; };{ x=8; y=1; value=1; };{ x=8; y=2; value=0; };{ x=8; y=3; value=0; };{ x=8; y=4; value=8; };{ x=8; y=5; value=0; };{ x=8; y=6; value=0; };{ x=8; y=7; value=9; };{ x=8; y=8; value=0; };
        ] |> List.sort }
        let puzzle = readSudokuFile filePath
        Assert.Equal(expectedPuzzle, puzzle)

    [<Fact>]
    let ``extractNumbersFromRow when given valid number string returns number list`` () =
        let numberString = "003020600"
        let expectedNumbers = [0;0;3;0;2;0;6;0;0;]
        let numbers = extractNumbersFromRow numberString
        Assert.Equal<int list>(expectedNumbers, numbers)

    //[<Property>]
    //let ``extractNumbersFromRow`` (row: string) = 
    //    Sudoku.extractNumbersFromRow row = expectedNumbers