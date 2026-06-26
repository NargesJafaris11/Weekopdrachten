namespace Weekopdrachten.Opdracht19;

public class WPark
{
    public string Name { get; set; }
    public List<Garage> Garages { get; set; }

    public WPark(string name)
    {
        Name = name;
        Garages = new List<Garage>();
    }

    public void AddGarage(Garage garage)
    {
        Garages.Add(garage);
    }

    public void RemoveGarage(string garageName)
    {
        Garages.RemoveAll(garage => garage.Name == garageName);
    }

    public void AddCar(string garageName, Car car)
    {
        Garage? garage = Garages.FirstOrDefault(g => g.Name == garageName);

        if (garage != null)
        {
            garage.AddCar(car);
        }
    }

    public void RemoveCar(string garageName, string vin)
    {
        Garage? garage = Garages.FirstOrDefault(g => g.Name == garageName);

        if (garage != null)
        {
            garage.RemoveCar(vin);
        }
    }

    public void DisplayList()
    {
        Console.WriteLine($"Bedrijf: {Name}");
        Console.WriteLine();

        foreach (Garage garage in Garages)
        {
            garage.DisplayList();
        }
    }
}