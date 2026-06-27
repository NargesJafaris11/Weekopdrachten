using Weekopdrachten.Helpers;

namespace Weekopdrachten.Opdracht23;

public static class Weekopdracht23
{
    private static readonly List<StaffMember> StaffMembers = new()
    {
        new StaffMember("Alice Andersen", 30, "Software Ontwikkelaar", "IT", "01-03-2015"),
        new StaffMember("Bob Brown", 45, "Project Manager", "Marketing", "15-06-2010"),
        new StaffMember("Charlie Chapman", 28, "Data Analist", "Analyse", "23-09-2018"),
        new StaffMember("Diana Douglas", 35, "HR Manager", "Human Resources", "30-01-2012"),
        new StaffMember("Evan Edwards", 40, "Netwerkbeheerder", "IT", "19-05-2008"),
        new StaffMember("Fiona Fisher", 25, "Marketing Specialist", "Marketing", "01-07-2019"),
        new StaffMember("George Green", 32, "Product Manager", "Productontwikkeling", "17-11-2014"),
        new StaffMember("Hannah Harris", 38, "Sales Manager", "Verkoop", "12-04-2009"),
        new StaffMember("Ian Irving", 29, "Customer Support Medewerker", "Klantenservice", "29-02-2016")
    };

    public static async Task Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 23: Personeel");
        Console.WriteLine();

        List<string> staffMemberNames = new()
        {
            "Alice Andersen",
            "Bob Brown",
            "Charlie Chapman",
            "Diana Douglas",
            "Evan Edwards",
            "Fiona Fisher",
            "George Green",
            "Hannah Harris",
            "Ian Irving"
        };

        List<Task<StaffMember>> tasks = new();

        foreach (var name in staffMemberNames) tasks.Add(GetStaffMemberAsync(name));

        while (tasks.Count > 0)
        {
            Task<StaffMember> finishedTask = await Task.WhenAny(tasks);
            var staffMember = await finishedTask;

            Console.WriteLine(staffMember);

            tasks.Remove(finishedTask);
        }

        Console.WriteLine();
        Console.WriteLine("Alle personeelsleden zijn geladen.");
        ConsoleHelper.Pause();
    }

    private static async Task<StaffMember> GetStaffMemberAsync(string fullName)
    {
        await Task.Delay(new Random().Next(1000, 5000));

        return StaffMembers.First(member => member.FullName == fullName);
    }
}