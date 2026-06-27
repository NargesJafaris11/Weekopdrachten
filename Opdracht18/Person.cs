namespace Weekopdrachten.Opdracht18;

public class Person
{
    private static int instanceCounter;

    public Person(string name)
    {
        Name = name;
        instanceCounter++;
    }

    public string Name { get; set; }

    public static int InstanceCount()
    {
        return instanceCounter;
    }
}