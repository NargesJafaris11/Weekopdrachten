using Weekopdrachten.Helpers;
namespace Weekopdrachten.Opdracht19;

public static class Weekopdracht19
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 19");

        var car1 = new Car("Toyota", "Corolla", "Blauw", "Narges", 2020, "VIN001");
        var car2 = new Car("BMW", "X5", "Zwart", "Sara", 2022, "VIN002");
        var car3 = new Car("Volkswagen", "Golf", "Wit", "Ali", 2019, "VIN003");

        var garage1 = new Garage("Garage Almere");
        var garage2 = new Garage("Garage Lelystad");

        garage1.AddCar(car1);
        garage1.AddCar(car2);
        garage2.AddCar(car3);

        var bedrijf = new WPark("W-Park");

        bedrijf.AddGarage(garage1);
        bedrijf.AddGarage(garage2);

        bedrijf.DisplayList();

        Console.WriteLine("Auto VIN002 verwijderen uit Garage Almere...");
        bedrijf.RemoveCar("Garage Almere", "VIN002");

        Console.WriteLine();
        bedrijf.DisplayList();
        
        ConsoleHelper.Pause();
    }
}