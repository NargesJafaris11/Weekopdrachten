namespace Weekopdrachten.Opdracht25;

public class Printer(IPrintStrategy printStrategy)
{
    private IPrintStrategy _printStrategy = printStrategy;

    public void SetStrategy(IPrintStrategy printStrategy)
    {
        _printStrategy = printStrategy;
    }

    public void Print(string text)
    {
        _printStrategy.Print(text);
    }
}