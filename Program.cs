using Weekopdrachten.BasisOpdrachten;
using Weekopdrachten.Helpers;
using Weekopdrachten.Opdracht15;
using Weekopdrachten.Opdracht16;
using Weekopdrachten.Opdracht17;
using Weekopdrachten.Opdracht18;
using Weekopdrachten.Opdracht19;
using Weekopdrachten.Opdracht20;
using Weekopdrachten.Opdracht22;
using Weekopdrachten.Opdracht23;
using Weekopdrachten.Opdracht24;
using Weekopdrachten.Opdracht25;
using Weekopdrachten.Opdracht26;

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
    Console.WriteLine("23. Personeel");
    Console.WriteLine("24. Queue Threads");
    Console.WriteLine("25. Strategy Printer");
    Console.WriteLine("26. Boter-kaas-eieren");
    Console.WriteLine("0. Afsluiten");
    Console.Write("Kies een opdracht: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Opdracht1.Weekopdracht1();
            break;
        case "2":
            Opdracht2.Weekopdracht2();
            break;
        case "3":
            Opdracht3.Weekopdracht3();
            break;
        case "4":
            Opdracht4.Weekopdracht4();
            break;
        case "5":
            Opdracht5.Weekopdracht5();
            break;
        case "6":
            Opdracht6.Weekopdracht6();
            break;
        case "7":
            Opdracht7.Weekopdracht7();
            break;
        case "8":
            Opdracht8.Weekopdracht8();
            break;
        case "9":
            Opdracht9.Weekopdracht9();
            break;
        case "10":
            Opdracht10.Weekopdracht10();
            break;
        case "13":
            Opdracht13.Weekopdracht13();
            break;
        case "14":
            Opdracht14A.Weekopdracht14A();
            break;
        case "15":
            NotSoCleanCodeRefactored.Run();
            break;
        case "16":
            Weekopdracht16.Run();
            break;
        case "17":
            Weekopdracht17.Run();
            break;
        case "18":
            Weekopdracht18.Run();
            break;
        case "19":
            Weekopdracht19.Run();
            break;
        case "20":
            Weekopdracht20.Run();
            break;
        case "21":
            Weekopdracht21.Run();
            break;
        case "22":
            await Weekopdracht22.Run();
            break;
        case "23":
            await Weekopdracht23.Run();
            break;
        case "24":
            Weekopdracht24.Run();
            break;
        case "25":
            Weekopdracht25.Run();
            break;
        case "26":
            Weekopdracht26.Run();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Ongeldige keuze.");
            ConsoleHelper.Pause();
            break;
    }
}