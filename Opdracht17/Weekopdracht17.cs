namespace Weekopdrachten.Opdracht17;

public static class Weekopdracht17
{
    public static void Run()
    {
        Console.Clear();

        Console.WriteLine("17-1 Contactenlijst");
        Console.WriteLine("17-2 Encyclopedie");
        Console.WriteLine("17-3 Tekstverwerker");
        Console.WriteLine("17-4 Snackbar");
        Console.WriteLine("17-5 Kortingscodes");
        Console.WriteLine("17-6 Kortingscodes alternatief");
        Console.WriteLine("17-7 Muziekplaylist");
        Console.WriteLine("17-8 Containerterminal");

        Console.Write("Maak een keuze: ");
        var keuze = Console.ReadLine() ?? "";

        switch (keuze)
        {
            case "1":
                Contactenlijst.Run();
                break;

            case "2":
                Encyclopedie.Run();
                break;

            case "3":
                Tekstverwerker.Run();
                break;

            case "4":
                Snackbar.Run();
                break;

            case "5":
                Kortingscodes.Run();
                break;

            case "6":
                KortingscodesAlternatief.Run();
                break;

            case "7":
                MuziekPlaylist.Run();
                break;

            case "8":
                ContainerTerminal.Run();
                break;
        }
    }
}