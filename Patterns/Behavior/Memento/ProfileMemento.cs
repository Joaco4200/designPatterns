public class ProfileMemento
{
    public string name { get; }
    public int age { get; }
    
    // Constructor que recibe el estado del objeto a guardar.
    public ProfileMemento(string name, int age){
        this.name = name;
        this.age = age;
    }
}