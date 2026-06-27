namespace Weekopdrachten.Opdracht19;

public class Garage
{
    public Garage(string name)
    {
        Name = name;
        Cars = new List<Car>();
    }

    public string Name { get; set; }
    public List<Car> Cars { get; set; }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(string vin)
    {
        Cars.RemoveAll(car => car.VIN == vin);
    }

    public void DisplayList()
    {
        Console.WriteLine($"Garage: {Name}");

        foreach (var car in Cars) car.DisplayInfo();

        Console.WriteLine();
    }
}