using System;
using System.Collections.Generic;

namespace Weekopdrachten.Opdracht17;

public static class ContainerTerminal
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 17-8: Containerterminal");

        string[] containers =
        {
            "QVDM8009762", "CJIG1905934", "FGCM4664607", "CFLG6697633", "EQOD4660076",
            "PGLD2285677", "IISX5619237", "QMNU0970619", "SXKB8127565", "WBGZ9043382",
            "BVLZ9518548", "ZNSF2844985", "MRMV5005868", "PSWG7783254", "MYXT5104082",
            "GATM3160561", "XTXY3685126", "JFGQ5602926", "ICKQ5740110", "LLEN8095860",
            "DJQQ9473760", "MLUL9881099", "ZVZT6648738", "ZCFF1692285", "KDQD6427718"
        };

        // Stack gekozen omdat containers op elkaar gestapeld worden.
        // De bovenste container moet als eerste verplaatst worden.
        List<Stack<string>> stacks = new();

        for (int i = 0; i < 10; i++)
        {
            stacks.Add(new Stack<string>());
        }

        int stackIndex = 0;

        foreach (string container in containers)
        {
            stacks[stackIndex].Push(container);

            if (stacks[stackIndex].Count == 5)
            {
                stackIndex++;
            }
        }

        while (true)
        {
            Console.Clear();
            ToonStapels(stacks);

            Console.WriteLine();
            Console.WriteLine("1. Nieuwe container toevoegen");
            Console.WriteLine("2. Container ophalen");
            Console.WriteLine("0. Terug");
            Console.Write("Keuze: ");

            string keuze = Console.ReadLine() ?? "";

            switch (keuze)
            {
                case "1":
                    VoegContainerToe(stacks);
                    break;

                case "2":
                    HaalContainerOp(stacks);
                    break;

                case "0":
                    return;
            }
        }
    }

    private static void VoegContainerToe(List<Stack<string>> stacks)
    {
        Console.Write("Container nummer: ");
        string nummer = Console.ReadLine() ?? "";

        foreach (Stack<string> stack in stacks)
        {
            if (stack.Count < 5)
            {
                stack.Push(nummer);
                Console.WriteLine("Container toegevoegd.");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("Alle stapels zijn vol.");
        Console.ReadKey();
    }

    private static void HaalContainerOp(List<Stack<string>> stacks)
    {
        Console.Write("Welke container wil je ophalen? ");
        string gezocht = Console.ReadLine() ?? "";

        for (int i = 0; i < stacks.Count; i++)
        {
            if (stacks[i].Contains(gezocht))
            {
                Console.WriteLine($"Container gevonden op stapel {i + 1}.");

                while (stacks[i].Peek() != gezocht)
                {
                    string bovenste = stacks[i].Pop();
                    Console.WriteLine($"Verplaats container {bovenste} naar een andere stapel.");
                }

                stacks[i].Pop();
                Console.WriteLine($"Container {gezocht} is opgehaald.");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("Container niet gevonden.");
        Console.ReadKey();
    }

    private static void ToonStapels(List<Stack<string>> stacks)
    {
        Console.WriteLine("Containerterminal");
        Console.WriteLine();

        for (int i = 0; i < stacks.Count; i++)
        {
            Console.WriteLine($"Stapel {i + 1}:");

            foreach (string container in stacks[i])
            {
                Console.WriteLine($"  {container}");
            }

            Console.WriteLine();
        }
    }
}