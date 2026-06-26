namespace Weekopdrachten.Opdracht18;

public class Person
{
    private static int instanceCounter = 0;

    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
        instanceCounter++;
    }

    public static int InstanceCount()
    {
        return instanceCounter;
    }
}