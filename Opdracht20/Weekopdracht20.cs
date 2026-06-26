namespace Weekopdrachten.Opdracht20;

public interface IDrivable
{
    void Drive();
}

public interface IFlyable
{
    void Fly();
}

public interface ICargoCarrier
{
    void LoadCargo();
}

public abstract class Vehicle
{
    public string Color { get; set; }

    protected Vehicle(string color)
    {
        Color = color;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{Color} {GetType().Name} engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{Color} {GetType().Name} engine stopped");
    }
}

public class Bike : Vehicle, IDrivable
{
    public Bike(string color) : base(color)
    {
    }

    public void Drive()
    {
        Console.WriteLine($"Riding a {Color.ToLower()} bike");
    }
}

public class Car : Vehicle, IDrivable
{
    public Car(string color) : base(color)
    {
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {Color.ToLower()} car");
    }
}

public class Truck : Vehicle, IDrivable, ICargoCarrier
{
    public Truck(string color) : base(color)
    {
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {Color.ToLower()} truck");
    }

    public void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {Color.ToLower()} truck");
    }
}

public class Plane : Vehicle, IDrivable, IFlyable
{
    public Plane(string color) : base(color)
    {
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {Color.ToLower()} plane on the ground");
    }

    public void Fly()
    {
        Console.WriteLine($"Flying a {Color.ToLower()} plane");
    }
}

public class CargoPlane : Vehicle, IDrivable, IFlyable, ICargoCarrier
{
    public CargoPlane(string color) : base(color)
    {
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {Color.ToLower()} cargo plane on the ground");
    }

    public void Fly()
    {
        Console.WriteLine($"Flying a {Color.ToLower()} cargo plane");
    }

    public void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {Color.ToLower()} cargo plane");
    }
}

public static class Weekopdracht20
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 20: Class, Inheritance en Interface");
        Console.WriteLine();

        Vehicle[] vehicles =
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

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.StartEngine();

            if (vehicle is IDrivable drivable)
            {
                drivable.Drive();
            }

            if (vehicle is IFlyable flyable)
            {
                flyable.Fly();
            }

            if (vehicle is ICargoCarrier cargoCarrier)
            {
                cargoCarrier.LoadCargo();
            }

            vehicle.StopEngine();
            Console.WriteLine();
        }

        Console.WriteLine("Druk op een toets...");
        Console.ReadKey();
    }
}