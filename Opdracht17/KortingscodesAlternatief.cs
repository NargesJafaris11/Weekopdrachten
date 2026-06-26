namespace Weekopdrachten.Opdracht17;

public static class KortingscodesAlternatief
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 17-6: Kortingscodes (Dictionary)");
        Console.WriteLine();

        string[] discountCodes =
        {
            "P5CQV", "MVFHC", "P1WVX",
            "H15QA", "CKWX2", "B45SO",
            "1VRFH", "KSVQO", "WH83H",
            "AOZMT", "DSTCH", "VQ1H6",
            "C03GB", "1N9YM", "8W7F8"
        };

        // Dictionary gekozen omdat we per kortingscode kunnen opslaan
        // of deze al gebruikt is.
        Dictionary<string, bool> kortingscodes = new();

        foreach (string code in discountCodes)
        {
            kortingscodes.Add(code, false);
        }

        while (true)
        {
            Console.Write("Voer een kortingscode in (q = stoppen): ");
            string code = (Console.ReadLine() ?? "").ToUpper();

            if (code == "Q")
            {
                break;
            }

            if (!kortingscodes.ContainsKey(code))
            {
                Console.WriteLine("Ongeldige kortingscode.");
            }
            else if (kortingscodes[code])
            {
                Console.WriteLine("Deze kortingscode is al gebruikt.");
            }
            else
            {
                kortingscodes[code] = true;
                Console.WriteLine("Kortingscode is geldig en is nu gebruikt.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Druk op een toets om terug te gaan.");
        Console.ReadKey();
    }
}