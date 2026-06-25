namespace Weekopdrachten.Opdracht15;

public static class NotSoCleanCodeRefactored
{
    public static void Run()
    {
        PrintGreeting();
        RunCalculator();
    }

    private static void PrintGreeting()
    {
        Console.WriteLine("Welkom bij de Rekenmachine!");
    }

    private static void RunCalculator()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine();
            Console.WriteLine("Complexere Rekenmachine");
            Console.WriteLine("Kies een operatie: +, -, *, /, %, ^, sqrt, 18+");

            string operation = Console.ReadLine() ?? "";

            if (operation == "18+")
            {
                CheckAge();
            }
            else
            {
                Calculate(operation);
            }

            Console.WriteLine();
            Console.Write("Wilt u doorgaan? (ja/nee): ");
            continueCalculating = (Console.ReadLine() ?? "").ToLower().Trim() == "ja";
        }
    }

    private static void Calculate(string operation)
    {
        double number1 = ReadDouble("Voer het eerste getal in:");
        double number2 = 0;

        if (operation != "sqrt")
        {
            number2 = ReadDouble("Voer het tweede getal in:");
        }

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Resultaat: {number1} + {number2} = {number1 + number2}");
                break;
            case "-":
                Console.WriteLine($"Resultaat: {number1} - {number2} = {number1 - number2}");
                break;
            case "*":
                Console.WriteLine($"Resultaat: {number1} * {number2} = {number1 * number2}");
                break;
            case "/":
                Console.WriteLine(number2 == 0
                    ? "Delen door nul is niet toegestaan."
                    : $"Resultaat: {number1} / {number2} = {number1 / number2}");
                break;
            case "%":
                Console.WriteLine($"Resultaat: {number1} % {number2} = {number1 % number2}");
                break;
            case "^":
                Console.WriteLine($"Resultaat: {number1} ^ {number2} = {Math.Pow(number1, number2)}");
                break;
            case "sqrt":
                Console.WriteLine(number1 < 0
                    ? "Wortel van een negatief getal is niet toegestaan."
                    : $"Resultaat: √{number1} = {Math.Sqrt(number1)}");
                break;
            default:
                Console.WriteLine("Ongeldige operatie.");
                break;
        }
    }

    private static double ReadDouble(string message)
    {
        double number;

        while (true)
        {
            Console.WriteLine(message);

            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }

            Console.WriteLine("Ongeldige invoer, voer een getal in.");
        }
    }

    private static int ReadInt(string message)
    {
        int number;

        while (true)
        {
            Console.WriteLine(message);

            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }

            Console.WriteLine("Ongeldige invoer, voer een geheel getal in.");
        }
    }

    private static void CheckAge()
    {
        int day = ReadInt("Voer je geboortedag in:");
        int month = ReadInt("Voer je geboortemaand in:");
        int year = ReadInt("Voer je geboortejaar in:");

        bool isValidDate = DateOnly.TryParse($"{year}-{month}-{day}", out DateOnly birthDate);

        if (!isValidDate)
        {
            Console.WriteLine("Ongeldige geboortedatum.");
            return;
        }

        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        int age = today.Year - birthDate.Year;

        if (birthDate > today.AddYears(-age))
        {
            age--;
        }

        Console.WriteLine(age >= 18 ? "Resultaat: 18+" : "Resultaat: jonger dan 18!");
    }
}