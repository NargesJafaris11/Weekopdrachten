using Weekopdrachten.Helpers;

namespace Weekopdrachten.BasisOpdrachten;

public class Opdracht14A
{
    public static void Weekopdracht14A()
    {
        Console.Clear();
        Console.WriteLine("Fibonacci");

        Console.Write("Hoeveel getallen wil je zien? ");
        var aantal = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("\nIteratief:");
        FibonacciIteratief(aantal);

        Console.WriteLine("\nRecursief:");
        for (var i = 0; i < aantal; i++) Console.Write(FibonacciRecursief(i) + " ");

        Console.WriteLine("\n\nDynamisch:");
        FibonacciDynamisch(aantal);

        ConsoleHelper.Pause();
    }

    private static void FibonacciIteratief(int aantal)
    {
        var a = 0;
        var b = 1;

        for (var i = 0; i < aantal; i++)
        {
            Console.Write(a + " ");

            var temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }

    private static int FibonacciRecursief(int n)
    {
        if (n <= 1) return n;

        return FibonacciRecursief(n - 1) + FibonacciRecursief(n - 2);
    }

    private static void FibonacciDynamisch(int aantal)
    {
        var fib = new int[aantal];

        fib[0] = 0;

        if (aantal > 1) fib[1] = 1;

        for (var i = 2; i < aantal; i++) fib[i] = fib[i - 1] + fib[i - 2];

        foreach (var getal in fib) Console.Write(getal + " ");

        Console.WriteLine();
    }
}