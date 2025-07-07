public class ProfileMemento
{
    public string name { get; }
    public int age { get; }

    public ProfileMemento(string name, int age) // Constructor que recibe el estado del objeto a guardar.
    {
        this.name = name;
        this.age = age;
    }
}