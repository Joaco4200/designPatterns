public class Listener
{
    private string username;
    public Listener(string username)
    {
        this.user = username;
    }

    //metodo que hace realmente HACE lo que quiero que se haga a todos los listeners.
    public void update()
    {
        Console.WriteLine($"Notification sent to {username}");
    }
}