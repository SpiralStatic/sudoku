using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Sudoku.Core;

namespace Sudoku.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            var sudokuFileReader = new SudokuFileReader("../../../../Sudoku.Core.Test/SudokuInputFiles/sudoku_example_single.txt");
            NumberGrid numberGrid = sudokuFileReader.ReadSudoku();

            var sudokuSolver = new SudokuSolver(numberGrid, serviceProvider.GetRequiredService<ILogger<SudokuSolver>>());
            sudokuSolver.Solve();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(logger =>
            {
                logger.ClearProviders();
                logger.AddSerilog();
            });
        }
    }
}
