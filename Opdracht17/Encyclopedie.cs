namespace Weekopdrachten.Opdracht17;

public static class Encyclopedie
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 17-2: Encyclopedie");

        string[,] testData = new string[15, 2]
        {
            {"Abstractie", "Het proces van het weglaten van minder essentiële informatie zodat alleen de meest essentiële kenmerken overblijven."},
            {"Algoritme", "Een stapsgewijze procedure voor het uitvoeren van een taak of het berekenen van een waarde."},
            {"Array", "Een geordende verzameling elementen, typisch van hetzelfde type."},
            {"Class", "Een blauwdruk voor een object in objectgeoriënteerd programmeren."},
            {"Encapsulatie", "Een objectgeoriënteerd programmeerprincipe waarbij de interne staat van een object verborgen wordt."},
            {"Erfenis", "Het vermogen van een nieuwe klasse om de eigenschappen en methoden van een andere klasse over te nemen."},
            {"Framework", "Een set van codebibliotheken en tools die helpen bij het ontwikkelen van software."},
            {"Interface", "Een contract in OOP dat definieert welke methodes een klasse moet implementeren."},
            {"Iteratie", "Het herhaaldelijk uitvoeren van een set instructies totdat een bepaalde voorwaarde is voldaan."},
            {"Namespace", "Een container die wordt gebruikt om sets van andere benoemde entiteiten onder een unieke naam te groeperen."},
            {"Polymorfisme", "Het vermogen van verschillende klassen om te reageren op dezelfde boodschap op verschillende manieren."},
            {"Recursie", "Een techniek in programmeren waar een functie zichzelf oproept."},
            {"Serialize", "Het proces van omzetten van een object naar een formaat dat kan worden opgeslagen of overgedragen."},
            {"Syntax", "De set regels die definiëren hoe instructies in een programmeertaal zijn opgebouwd."},
            {"Variable", "Een opslaglocatie met een geassocieerde naam en een waarde die kan veranderen tijdens de uitvoering van een programma."}
        };

        // Dictionary gekozen omdat ieder begrip uniek is
        // en snel op basis van een sleutel gezocht kan worden.
        Dictionary<string, string> encyclopedie = new();

        for (int i = 0; i < testData.GetLength(0); i++)
        {
            encyclopedie.Add(testData[i, 0], testData[i, 1]);
        }

        Console.WriteLine();
        Console.WriteLine("Beschikbare begrippen:");

        foreach (string item in encyclopedie.Keys)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine();
        Console.Write("Kies een begrip: ");
        string begrip = Console.ReadLine() ?? "";

        if (encyclopedie.ContainsKey(begrip))
        {
            Console.WriteLine(encyclopedie[begrip]);
        }
        else
        {
            Console.WriteLine("Begrip niet gevonden.");
        }
    }
}