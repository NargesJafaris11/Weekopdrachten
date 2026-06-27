namespace Weekopdrachten.Opdracht17;

public static class MuziekPlaylist
{
    public static void Run()
    {
        string[] music =
        {
            "Lady Gaga - Shallow",
            "Drake - Memories",
            "Shawn Mendes - Blinding Lights",
            "Maroon 5 - Memories",
            "Adele - Shallow",
            "Lady Gaga - Yellow",
            "The Weeknd - Leave the Door Open",
            "Imagine Dragons - Positions",
            "Adele - Positions",
            "The Weeknd - Someone Like You",
            "Adele - Positions",
            "Coldplay - Memories",
            "Dua Lipa - Good 4 U",
            "Billie Eilish - Blinding Lights",
            "Drake - Leave the Door Open"
        };

        // LinkedList gekozen omdat nummers makkelijk aan begin,
        // einde en midden toegevoegd en verplaatst kunnen worden.
        LinkedList<string> playlist = new LinkedList<string>(music);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Weekopdracht 17-7: Muziekplaylist");
            Console.WriteLine();

            ToonPlaylist(playlist);

            Console.WriteLine();
            Console.WriteLine("1. Toevoegen aan begin");
            Console.WriteLine("2. Toevoegen aan einde");
            Console.WriteLine("3. Toevoegen na positie");
            Console.WriteLine("4. Verplaats nummer");
            Console.WriteLine("0. Stoppen");
            Console.Write("Maak een keuze: ");

            var keuze = Console.ReadLine() ?? "";

            switch (keuze)
            {
                case "1":
                    Console.Write("Nieuw nummer: ");
                    playlist.AddFirst(Console.ReadLine() ?? "");
                    break;

                case "2":
                    Console.Write("Nieuw nummer: ");
                    playlist.AddLast(Console.ReadLine() ?? "");
                    break;

                case "3":
                    Console.Write("Na welke positie toevoegen? ");
                    var positie = int.Parse(Console.ReadLine() ?? "1");

                    LinkedListNode<string>? node = ZoekNodeOpPositie(playlist, positie);

                    if (node == null)
                    {
                        Console.WriteLine("Ongeldige positie.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Nieuw nummer: ");
                        var nieuwNummer = Console.ReadLine() ?? "";
                        playlist.AddAfter(node, nieuwNummer);
                    }

                    break;

                case "4":
                    Console.Write("Welke positie wil je verplaatsen? ");
                    var oudePositie = int.Parse(Console.ReadLine() ?? "1");

                    LinkedListNode<string>? teVerplaatsen = ZoekNodeOpPositie(playlist, oudePositie);

                    if (teVerplaatsen == null)
                    {
                        Console.WriteLine("Ongeldige oude positie.");
                        Console.ReadKey();
                        break;
                    }

                    var nummer = teVerplaatsen.Value;
                    playlist.Remove(teVerplaatsen);

                    Console.Write("Naar welke positie wil je verplaatsen? ");
                    var nieuwePositie = int.Parse(Console.ReadLine() ?? "1");

                    if (nieuwePositie < 1 || nieuwePositie > playlist.Count + 1)
                    {
                        Console.WriteLine("Ongeldige nieuwe positie.");
                        Console.ReadKey();
                        playlist.AddLast(nummer);
                        break;
                    }

                    if (nieuwePositie == 1)
                    {
                        playlist.AddFirst(nummer);
                    }
                    else if (nieuwePositie == playlist.Count + 1)
                    {
                        playlist.AddLast(nummer);
                    }
                    else
                    {
                        LinkedListNode<string>? doelNode = ZoekNodeOpPositie(playlist, nieuwePositie);
                        playlist.AddBefore(doelNode!, nummer);
                    }

                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Ongeldige keuze.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void ToonPlaylist(LinkedList<string> playlist)
    {
        var i = 1;

        foreach (var nummer in playlist)
        {
            Console.WriteLine($"{i}. {nummer}");
            i++;
        }
    }

    private static LinkedListNode<string>? ZoekNodeOpPositie(
        LinkedList<string> playlist,
        int positie)
    {
        if (positie < 1 || positie > playlist.Count) return null;

        LinkedListNode<string>? current = playlist.First;

        for (var i = 1; i < positie; i++) current = current?.Next;

        return current;
    }
}