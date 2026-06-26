namespace Weekopdrachten.Opdracht25;

public class UpperCasePrintStrategy : IPrintStrategy
{
    public void Print(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
}