public class SomeService
{
    private static SomeService _instance;

    // Private constructor to prevent instantiation
    private SomeService()
    {
    }

    // Public method to provide access to the singleton instance
    public static SomeService GetInstance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SomeService();
            }
            return _instance;
        }
    }

    // Example method in the service
    public void DoSomething()
    {
        Console.WriteLine("Doing something in the singleton service.");
    }
}