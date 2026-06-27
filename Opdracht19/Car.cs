namespace Weekopdrachten.Opdracht19;

public class Car
{
    public Car(string brand, string type, string color, string owner, int year, string vin)
    {
        Brand = brand;
        Type = type;
        Color = color;
        Owner = owner;
        Year = year;
        VIN = vin;
    }

    public string Brand { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }
    public int Year { get; set; }
    public string VIN { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Brand} {Type}, {Color}, {Year}, eigenaar: {Owner}, VIN: {VIN}");
    }
}