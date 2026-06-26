namespace Weekopdrachten.Opdracht25;

public static class Weekopdracht25
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Weekopdracht 25: Strategy Pattern");
            Console.WriteLine();

            Console.WriteLine("Voer tekst in om uit te printen");
            string text = Console.ReadLine() ?? "";

            Console.WriteLine("(1) 1 keer");
            Console.WriteLine("(2) Herhaald");
            Console.WriteLine("(3) Met sterren");
            Console.WriteLine("(4) Achterstevoren");
            Console.WriteLine("(5) Hoofdletters");
            Console.WriteLine("(0) Terug");

            int choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 0)
                return;

            IPrintStrategy strategy;

            switch (choice)
            {
                case 2:
                    Console.Write("Hoe vaak? ");
                    int count = int.Parse(Console.ReadLine() ?? "1");
                    strategy = new RepeatPrintStrategy(count);
                    break;

                case 3:
                    strategy = new StarsPrintStrategy();
                    break;

                case 4:
                    strategy = new ReversePrintStrategy();
                    break;

                case 5:
                    strategy = new UpperCasePrintStrategy();
                    break;

                default:
                    strategy = new NormalPrintStrategy();
                    break;
            }

            Printer printer = new Printer(strategy);
            printer.Print(text);

            Console.WriteLine();
            Console.WriteLine("Druk op een toets...");
            Console.ReadKey();
        }
    }
}