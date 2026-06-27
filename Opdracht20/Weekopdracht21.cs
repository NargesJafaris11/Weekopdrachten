using Weekopdrachten.Helpers;

namespace Weekopdrachten.Opdracht20;

public static class Weekopdracht21
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 21: Polymorfisme");
        Console.WriteLine();

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Bike("Red"),
            new Bike("Yellow"),
            new Bike("Blue"),

            new Car("Red"),
            new Car("Yellow"),
            new Car("Blue"),

            new Truck("Red"),
            new Truck("Yellow"),
            new Truck("Blue"),

            new Plane("Red"),
            new Plane("Yellow"),
            new Plane("Blue"),

            new CargoPlane("Red"),
            new CargoPlane("Yellow"),
            new CargoPlane("Blue")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();

            if (vehicle is IDrivable drivable) drivable.Drive();

            if (vehicle is IFlyable flyable) flyable.Fly();

            if (vehicle is ICargoCarrier cargoCarrier) cargoCarrier.LoadCargo();

            vehicle.StopEngine();
            Console.WriteLine();
        }
            ConsoleHelper.Pause();
    }
}