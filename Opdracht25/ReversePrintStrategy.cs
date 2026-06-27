namespace Weekopdrachten.Opdracht25;

public class ReversePrintStrategy : IPrintStrategy
{
    public void Print(string text)
    {
        var letters = text.ToCharArray();
        Array.Reverse(letters);
        Console.WriteLine(new string(letters));
    }
}