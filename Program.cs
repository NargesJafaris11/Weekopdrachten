using Weekopdrachten.Opdracht16;
using Weekopdrachten.Opdracht18;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Weekopdrachten C# ===");
    Console.WriteLine("1. Switch");
    Console.WriteLine("2. If-Else");
    Console.WriteLine("3. Hoger-Lager Spel");
    Console.WriteLine("4. Do-While");
    Console.WriteLine("5. FizzBuzz");
    Console.WriteLine("6. Foreach");
    Console.WriteLine("7. Break");
    Console.WriteLine("8. Continue");
    Console.WriteLine("9. Ternary Operator");
    Console.WriteLine("10. Quiz");
    Console.WriteLine("13. FizzBuzzBang");
    Console.WriteLine("14. Fibonacci");
    Console.WriteLine("15. NotSoCleanCode");
    Console.WriteLine("16. DigiSchool");
    Console.WriteLine("17. Collections");
    Console.WriteLine("18. OOP basics");
    Console.WriteLine("19. W-Park");
    Console.WriteLine("20. Floris");
    Console.WriteLine("21. Polymorfisme");
    Console.WriteLine("22. CSV files");
    Console.WriteLine("0. Afsluiten");
    Console.Write("Kies een opdracht: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Weekopdracht1();
            break;
        case "2":
            Weekopdracht2();
            break;
        case "3":
            Weekopdracht3();
            break;
        case "4":
            Weekopdracht4();
            break;
        case "5":
            Weekopdracht5();
            break;
        case "6":
            Weekopdracht6();
            break;
        case "7":
            Weekopdracht7();
            break;
        case "8":
            Weekopdracht8();
            break;
        case "9":
            Weekopdracht9();
            break;
        case "10":
            Weekopdracht10();
            break;
        case "13":
            Weekopdracht13();
            break;
        case "14":
            Weekopdracht14A();
            break;
        case "15":
            Weekopdrachten.Opdracht15.NotSoCleanCodeRefactored.Run();
            break;
        case "16":
            Weekopdracht16();
            break;
        case "17":
            Weekopdrachten.Opdracht17.Weekopdracht17.Run();
            break;
        case "18":
            Weekopdracht18.Run();
            break;
        case "19":
            Weekopdrachten.Opdracht19.Weekopdracht19.Run();
            break;
        case "20":
            Weekopdrachten.Opdracht20.Weekopdracht20.Run();
            break;
        case "21":
            Weekopdrachten.Opdracht20.Weekopdracht21.Run();
            break;
        case "22":
            await Weekopdrachten.Opdracht22.Weekopdracht22.Run();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Ongeldige keuze.");
            Pause();
            break;
    }
}

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("Druk op een toets om naar het hoofdmenu te gaan.");
    Console.ReadKey();
}

static void Weekopdracht1()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 1: Switch");
    Console.Write("Voer een cijfer in van 1 t/m 10: ");

    bool isValidNumber = int.TryParse(Console.ReadLine(), out int grade);

    if (!isValidNumber || grade < 1 || grade > 10)
    {
        Console.WriteLine("Ongeldige invoer. Voer een getal in van 1 t/m 10.");
        Pause();
        return;
    }

    switch (grade)
    {
        case 1:
        case 2:
        case 3:
            Console.WriteLine("Slecht");
            break;
        case 4:
        case 5:
            Console.WriteLine("Matig");
            break;
        case 6:
            Console.WriteLine("Voldoende");
            break;
        case 7:
        case 8:
            Console.WriteLine("Goed");
            break;
        case 9:
        case 10:
            Console.WriteLine("Uitstekend");
            break;
    }

    Pause();
}

static void Weekopdracht2()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 2: If-Else");
    Console.Write("Voer een cijfer in van 1,0 t/m 10,0: ");

    bool isValidNumber = double.TryParse(Console.ReadLine(), out double grade);

    if (!isValidNumber || grade < 1.0 || grade > 10.0)
    {
        Console.WriteLine("Ongeldige invoer. Voer een getal in van 1,0 t/m 10,0.");
        Pause();
        return;
    }

    if (grade < 4.0)
    {
        Console.WriteLine("Slecht");
    }
    else if (grade < 5.5)
    {
        Console.WriteLine("Matig");
    }
    else if (grade < 7.0)
    {
        Console.WriteLine("Voldoende");
    }
    else if (grade < 8.5)
    {
        Console.WriteLine("Goed");
    }
    else
    {
        Console.WriteLine("Uitstekend");
    }

    Pause();
}

static void Weekopdracht3()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 3: Hoger-Lager");

    int secretNumber = Random.Shared.Next(1, 100);
    int guess = 0;
    int attempts = 0;

    while (guess != secretNumber)
    {
        Console.Write("Raad een getal tussen 1 en 99: ");

        bool isValidNumber = int.TryParse(Console.ReadLine(), out guess);

        if (!isValidNumber)
        {
            Console.WriteLine("Ongeldige invoer.");
            continue;
        }

        attempts++;

        if (guess < secretNumber)
        {
            Console.WriteLine("Hoger!");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("Lager!");
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Gefeliciteerd! Je hebt het getal geraden in {attempts} pogingen.");

    Pause();
}

static void Weekopdracht4()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 4: Do-While");

    int number;
    bool isValid;

    do
    {
        Console.Write("Voer een getal in tussen 1 en 10: ");

        isValid = int.TryParse(Console.ReadLine(), out number);

        if (!isValid || number < 1 || number > 10)
        {
            Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
        }

    } while (!isValid || number < 1 || number > 10);

    Console.WriteLine();
    Console.WriteLine($"Je hebt gekozen voor het getal {number}.");

    Pause();
}

static void Weekopdracht5()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 5: FizzBuzz");
    Console.WriteLine();

    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }

    Pause();
}

static void Weekopdracht6()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 6: Foreach");
    Console.WriteLine();

    List<string> namen = new List<string> {
        "Anna", "Bob", "Charlie", "Dave", "Eva", "Frank", "Grace", "Harry", "Ivy", "Jack"
    };

    foreach (string naam in namen)
    {
        if (naam.Length < 5)
        {
            Console.WriteLine(naam);
        }
    }

    Pause();
}

static void Weekopdracht7()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 7: Break");
    Console.WriteLine();

    int gevonden = 0;
    int getal = 2;

    while (true)
    {
        bool isPriem = true;

        for (int i = 2; i < getal; i++)
        {
            if (getal % i == 0)
            {
                isPriem = false;
                break;
            }
        }

        if (isPriem)
        {
            Console.WriteLine(getal);
            gevonden++;
        }

        if (gevonden == 10)
        {
            break;
        }

        getal++;
    }

    Pause();
}

static void Weekopdracht8()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 8: Continue");
    Console.WriteLine();

    for (int i = 1; i <= 50; i++)
    {
        if (i % 3 == 0)
        {
            continue;
        }

        Console.WriteLine(i);
    }

    Pause();
}

static void Weekopdracht9()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 9: Ternary Operator");
    Console.Write("Voer een score in (0-100): ");

    bool isValid = int.TryParse(Console.ReadLine(), out int score);

    if (!isValid || score < 0 || score > 100)
    {
        Console.WriteLine("Ongeldige invoer.");
        Pause();
        return;
    }

    string beoordeling =
        score < 50 ? "Slecht" :
        score < 65 ? "Matig" :
        score < 75 ? "Voldoende" :
        score < 90 ? "Goed" :
        "Uitstekend";

    Console.WriteLine($"Beoordeling: {beoordeling}");

    Pause();
}

static void Weekopdracht10()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 10: Quiz");
    Console.WriteLine();

    int score = 0;

    Console.WriteLine("Vraag 1: Wat is de hoofdstad van Nederland?");
    Console.WriteLine("a) Rotterdam");
    Console.WriteLine("b) Amsterdam");
    Console.WriteLine("c) Utrecht");
    string antwoord1 = (Console.ReadLine() ?? "").ToLower().Trim();

    if (antwoord1 == "b" || antwoord1 == "amsterdam")
    {
        score++;
        Console.WriteLine("Goed!");
    }
    else
    {
        Console.WriteLine("Fout!");
    }

    Console.WriteLine();

    Console.WriteLine("Vraag 2: Hoeveel dagen heeft een week?");
    Console.WriteLine("a) 5");
    Console.WriteLine("b) 6");
    Console.WriteLine("c) 7");
    string antwoord2 = (Console.ReadLine() ?? "").ToLower().Trim();

    if (antwoord2 == "c" || antwoord2 == "7")
    {
        score++;
        Console.WriteLine("Goed!");
    }
    else
    {
        Console.WriteLine("Fout!");
    }

    Console.WriteLine();

    Console.WriteLine("Vraag 3: Welke taal gebruiken we hier?");
    Console.WriteLine("a) C#");
    Console.WriteLine("b) Java");
    Console.WriteLine("c) Python");
    string antwoord3 = (Console.ReadLine() ?? "").ToLower().Trim();

    if (antwoord3 == "a" || antwoord3 == "c#" || antwoord3 == "csharp")
    {
        score++;
        Console.WriteLine("Goed!");
    }
    else
    {
        Console.WriteLine("Fout!");
    }

    Console.WriteLine();

    Console.WriteLine("Vraag 4: Hoeveel maanden heeft een jaar?");
    Console.WriteLine("a) 10");
    Console.WriteLine("b) 12");
    Console.WriteLine("c) 14");
    string antwoord4 = (Console.ReadLine() ?? "").ToLower().Trim();

    if (antwoord4 == "b" || antwoord4 == "12")
    {
        score++;
        Console.WriteLine("Goed!");
    }
    else
    {
        Console.WriteLine("Fout!");
    }

    Console.WriteLine();

    Console.WriteLine("Vraag 5: Welk keyword gebruik je om een klasse te laten erven van een andere klasse?");
    Console.WriteLine("a) inherits");
    Console.WriteLine("b) extends");
    Console.WriteLine("c) :");
    string antwoord5 = (Console.ReadLine() ?? "").ToLower().Trim();

    if (antwoord5 == "c" || antwoord5 == ":")
    {
        score++;
        Console.WriteLine("Goed!");
    }
    else
    {
        Console.WriteLine("Fout!");
    }

    Console.WriteLine();
    Console.WriteLine($"Je score is: {score}/5");

    Pause();
}

static void Weekopdracht13()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 13: FizzBuzzBang");
    Console.WriteLine();

    for (int i = 1; i <= 100; i++)
    {
        string output = "";

        if (i % 3 == 0)
            output += "Fizz";

        if (i % 5 == 0)
            output += "Buzz";

        if (i % 7 == 0)
            output += "Bang";

        Console.WriteLine(string.IsNullOrEmpty(output)
            ? i.ToString()
            : output);
    }

    Pause();
}

static void Weekopdracht14A()
{
    Console.Clear();
    Console.WriteLine("Fibonacci");

    Console.Write("Hoeveel getallen wil je zien? ");
    int aantal = int.Parse(Console.ReadLine());

    Console.WriteLine("\nIteratief:");
    FibonacciIteratief(aantal);

    Console.WriteLine("\nRecursief:");
    for (int i = 0; i < aantal; i++)
    {
        Console.Write(FibonacciRecursief(i) + " ");
    }

    Console.WriteLine("\n\nDynamisch:");
    FibonacciDynamisch(aantal);

    Pause();
}

static void FibonacciIteratief(int aantal)
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < aantal; i++)
    {
        Console.Write(a + " ");

        int temp = a + b;
        a = b;
        b = temp;
    }

    Console.WriteLine();
}

static int FibonacciRecursief(int n)
{
    if (n <= 1)
    {
        return n;
    }

    return FibonacciRecursief(n - 1) + FibonacciRecursief(n - 2);
}

static void FibonacciDynamisch(int aantal)
{
    int[] fib = new int[aantal];

    fib[0] = 0;

    if (aantal > 1)
    {
        fib[1] = 1;
    }

    for (int i = 2; i < aantal; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }

    foreach (int getal in fib)
    {
        Console.Write(getal + " ");
    }

    Console.WriteLine();
}

static void Weekopdracht16()
{
    Console.Clear();

    var teacher = new Teacher(
        "Tom",
        "tom@school.nl",
        40,
        "C#",
        10);

    var student = new Student(
        "Narges",
        "narges@student.nl",
        30,
        "S12345",
        "HBO-ICT");

    Console.WriteLine(teacher);
    Console.WriteLine(student);

    Console.WriteLine();

    Material book = new Book(
        "C# Boek",
        "Docent",
        2024,
        250);

    Material video = new Video(
        "OOP Uitleg",
        "Docent",
        2024,
        15);

    book.DisplayInfo();
    video.DisplayInfo();

    Pause();
}

static void Weekopdracht17()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 17-1: Contactenlijst");
    
    List<string> contacts = new List<string>
    {
        "Emma Mulder",
        "Sara De Groot",
        "Emma Bakker",
        "Milan Van Dijk",
        "Emma Smit",
        "Daan Meijer",
        "Julia Visser",
        "Noah Mulder",
        "Julia Smit",
        "Sara Van Dijk",
        "Levi De Groot",
        "Tess Visser",
        "Sem Smit",
        "Levi Visser",
        "Sara De Boer"
    };

    for (int i = 0; i < contacts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {contacts[i]}");
    }

    Console.WriteLine();
    Console.Write("Welk contact wil je verwijderen? Kies nummer: ");

    if (int.TryParse(Console.ReadLine(), out int choice) &&
        choice >= 1 &&
        choice <= contacts.Count)
    {
        Console.WriteLine($"{contacts[choice - 1]} is verwijderd.");
        contacts.RemoveAt(choice - 1);
    }
    else
    {
        Console.WriteLine("Ongeldige keuze.");
    }

    Console.WriteLine();
    Console.WriteLine("Nieuwe contactenlijst:");

    for (int i = 0; i < contacts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {contacts[i]}");
    }

    Pause();
}

