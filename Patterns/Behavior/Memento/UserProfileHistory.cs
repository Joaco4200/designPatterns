public class UserProfileHistory
{
    public UserProfile userProfile; // Originator
    public Stack<ProfileMemento> history = new Stack<ProfileMemento>();

    // Guarda el estado actual del objeto en el historial.
    public void Save(ProfileMemento memento)
    {
        history.Push(memento);
    }

    public ProfileMemento Undo()
    {
        return history.Pop();
    }
}