namespace Weekopdrachten.Opdracht25;

public class RepeatPrintStrategy(int count) : IPrintStrategy
{
    public void Print(string text)
    {
        for (var i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}: {text}");
        }
    }
}