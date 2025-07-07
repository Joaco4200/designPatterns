//Originator
public class UserProfile
{
    public string Name { get; set; }
    public int Age { get; set; }
    public UserProfile(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void PrintProfile()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public ProfileMemento Save() //Guardo el estado actual del objeto.
    {
        return new ProfileMemento(Name, Age);
    }

    public void Restore(ProfileMemento memento) //Restaura el estado del objeto a partir de un memento.
    {
        this.Name = memento.Name;
        this.Age = memento.Age;
    }
}