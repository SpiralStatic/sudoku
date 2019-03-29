using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Sudoku.Core;
using System;
using System.IO;

namespace Sudoku.ConsoleApp
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;
        private static ISudokuReader _sudokuFileReader;

        public static int Main(string[] args)
        {
            ConfigureLogger();

            var argumentsSucessCode = ValidateArguments(args);
            if (argumentsSucessCode != ExitCode.Success)
            {
                Log.Logger.Fatal(argumentsSucessCode.ToString());
                return (int)argumentsSucessCode;
            }

            ConfigureServices();           

            SolveSudokuPuzzles(args);
          
            return (int)ExitCode.Success;
        }

        private static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
        }

        private static ExitCode ValidateArguments(string[] args)
        {
            if (args.Length < 1)
            {
                return ExitCode.NoArguments;
            }

            foreach (var sudokuFilePath in args)
            {
                if (!File.Exists(sudokuFilePath))
                {
                    return ExitCode.PuzzleDoesNotExist;
                }
            }

            return 0;
        }

        private static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging(logger =>
            {
                logger.ClearProviders();
                logger.AddSerilog();
            });

            _serviceProvider = serviceCollection.BuildServiceProvider();
            _sudokuFileReader = new SudokuFileReader();
        }

        private static ExitCode SolveSudokuPuzzles(string[] filePaths)
        {

            foreach(var sudokuFilePath in filePaths)
            {
                SudokuPuzzle puzzle = _sudokuFileReader.ReadSudoku(File.OpenRead(sudokuFilePath));
                var sudokuSolver = new SudokuSolver(_serviceProvider.GetRequiredService<ILogger<SudokuSolver>>());
                sudokuSolver.Solve(puzzle);
            }

            return ExitCode.Success;
        }
    }
}
