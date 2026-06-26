namespace Weekopdrachten.Opdracht25;

public class NormalPrintStrategy : IPrintStrategy
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}