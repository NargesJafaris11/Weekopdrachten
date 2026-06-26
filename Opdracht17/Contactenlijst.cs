namespace Weekopdrachten.Opdracht17;

public static class Contactenlijst
{
    public static void Run()
    {
        Console.Clear();
            Console.WriteLine("Weekopdracht 17-1: Contactenlijst");
            
            /* List gekozen omdat contacten op volgorde staan en eenvoudig op index
            opgehaald en verwijderd kunnen worden.*/
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
    }
}