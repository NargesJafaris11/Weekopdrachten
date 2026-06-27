namespace Weekopdrachten.Helpers;

public static class ConsoleHelper
{
    public static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Druk op een toets om naar het hoofdmenu te gaan.");
        Console.ReadKey();
    }
}