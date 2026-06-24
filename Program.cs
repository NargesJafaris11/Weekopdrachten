using System;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Weekopdrachten C# ===");
    Console.WriteLine("1. Switch");
    Console.WriteLine("2. If-Else");
    Console.WriteLine("3. Hoger-Lager Spel");
    Console.WriteLine("4. Do-While");
    Console.WriteLine("5. FizzBuzz");
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
    Console.WriteLine("Weekopdracht 2");
    Pause();
}

static void Weekopdracht3()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 3");
    Pause();
}

static void Weekopdracht4()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 4");
    Pause();
}

static void Weekopdracht5()
{
    Console.Clear();
    Console.WriteLine("Weekopdracht 5");
    Pause();
}