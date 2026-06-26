namespace Weekopdrachten.Opdracht25;

public class StarsPrintStrategy : IPrintStrategy
{
    public void Print(string text)
    {
        Console.WriteLine($"****{text}****");
    }
}