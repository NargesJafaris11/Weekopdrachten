namespace Weekopdrachten.Opdracht23;

public class StaffMember
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Function { get; set; }
    public string Department { get; set; }
    public string StartDate { get; set; }

    public StaffMember(string fullName, int age, string function, string department, string startDate)
    {
        FullName = fullName;
        Age = age;
        Function = function;
        Department = department;
        StartDate = startDate;
    }

    public override string ToString()
    {
        return $"{FullName}, {Age} jaar, {Function}, {Department}, gestart op {StartDate}";
    }
}