namespace Weekopdrachten.Opdracht18;

public static class Weekopdracht18
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 18-1");
        Console.WriteLine();

        var fiets1 = new Bicycle(LockType.RingLock, 54, Color.Black, BicycleType.Standard, 0);
        var fiets2 = new Bicycle(LockType.ChainLock, 58, Color.Blue, BicycleType.Electric, 80);
        var fiets3 = new Bicycle(LockType.NoLock, 50, Color.Red, BicycleType.Electric, 60);

        fiets1.LockBike();
        fiets2.UnlockBike();
        fiets3.LockBike();

        Console.WriteLine(fiets1.Print());
        Console.WriteLine(fiets2.Print());
        Console.WriteLine(fiets3.Print());

        Console.WriteLine("Calculator:");
        Console.WriteLine($"10 + 5 = {Calculator.Add(10, 5)}");
        Console.WriteLine($"10 - 5 = {Calculator.Sub(10, 5)}");
        Console.WriteLine();

        var person1 = new Person("Jan");
        var person2 = new Person("Piet");
        var person3 = new Person("Lisa");

        Console.WriteLine("Person:");
        Console.WriteLine($"Aantal personen: {Person.InstanceCount()}");
        Console.WriteLine();

        Console.WriteLine("Configuration:");
        Console.WriteLine($"Applicatie: {ConfigurationData.GetApplicationName()}");
        Console.WriteLine($"Versie: {ConfigurationData.GetVersion()}");
        Console.WriteLine($"Max gebruikers: {ConfigurationData.GetMaxUsers()}");
        Console.WriteLine();

        Console.WriteLine("Druk op een toets...");
        Console.ReadKey();
    }
}