namespace Weekopdrachten.Opdracht17;

public static class Kortingscodes
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 17-5: Kortingscodes");
        Console.WriteLine();

        string[] discountCodes =
        {
            "P5CQV", "MVFHC", "P1WVX",
            "H15QA", "CKWX2", "B45SO",
            "1VRFH", "KSVQO", "WH83H",
            "AOZMT", "DSTCH", "VQ1H6",
            "C03GB", "1N9YM", "8W7F8"
        };

        // HashSet gekozen omdat iedere kortingscode uniek is
        // en snel gecontroleerd kan worden of een code bestaat.
        HashSet<string> geldigeCodes = new HashSet<string>(discountCodes);

        // Hier bewaren we gebruikte codes.
        HashSet<string> gebruikteCodes = new HashSet<string>();
        
        while (true)
        {
            Console.Write("Voer een kortingscode in (q = stoppen): ");
            string code = (Console.ReadLine() ?? "").ToUpper();

            if (code == "Q")
            {
                break;
            }

            if (!geldigeCodes.Contains(code))
            {
                Console.WriteLine("Ongeldige kortingscode.");
            }
            else if (gebruikteCodes.Contains(code))
            {
                Console.WriteLine("Deze kortingscode is al gebruikt.");
            }
            else
            {
                gebruikteCodes.Add(code);
                Console.WriteLine("Kortingscode is geldig en is nu gebruikt.");
            }

            Console.WriteLine();
        }
        Console.ReadKey();
    }
}