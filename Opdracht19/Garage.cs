namespace Weekopdrachten.Opdracht19;

public class Garage
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }

    public Garage(string name)
    {
        Name = name;
        Cars = new List<Car>();
    }

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

        foreach (Car car in Cars)
        {
            car.DisplayInfo();
        }

        Console.WriteLine();
    }
}