//Originator
public class UserProfile
{
    public string name { get; set; }
    public int age { get; set; }
    public UserProfile(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void PrintProfile()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    public ProfileMemento Save() //Guardo el estado actual del objeto.
    {
        return new ProfileMemento(name, age);
    }

    public void Restore(ProfileMemento memento) //Restaura el estado del objeto a partir de un memento.
    {
        this.name = memento.name;
        this.age = memento.age;
    }
}