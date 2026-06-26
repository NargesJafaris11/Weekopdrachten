namespace Weekopdrachten.Opdracht18;

public static class ConfigurationData
{
    private const string ApplicationName = "Weekopdrachten App";
    private const string Version = "1.0";
    private const int MaxUsers = 100;

    public static string GetApplicationName()
    {
        return ApplicationName;
    }

    public static string GetVersion()
    {
        return Version;
    }

    public static int GetMaxUsers()
    {
        return MaxUsers;
    }
}