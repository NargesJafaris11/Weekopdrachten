using System.Diagnostics;

namespace Weekopdrachten.Opdracht22;

public static class Weekopdracht22
{
    public static async Task Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 22: CSV bestanden lezen");
        Console.WriteLine();

        string[] files =
        {
            "Opdracht22/C5A_data_1.csv",
            "Opdracht22/C5A_data_2.csv",
            "Opdracht22/C5A_data_3.csv",
            "Opdracht22/C5A_data_4.csv",
            "Opdracht22/C5A_data_5.csv"
        };

        Stopwatch stopwatch = Stopwatch.StartNew();

        foreach (string file in files)
        {
            int sum = await CalculateSumAsync(file);
            Console.WriteLine($"{Path.GetFileName(file)}: {sum}");
        }

        stopwatch.Stop();

        Console.WriteLine();
        Console.WriteLine($"Uitvoertijd: {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine();
        Console.WriteLine("Druk op een toets...");
        Console.ReadKey();
    }

    private static async Task<int> CalculateSumAsync(string filePath)
    {
        string content = await File.ReadAllTextAsync(filePath);

        string[] values = content.Split(
            new[] { ',', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        foreach (string value in values)
        {
            sum += int.Parse(value);
        }

        return sum;
    }
}