public class NotificationService
{
    private List<IListener> listeners = new List<IListener>();
    
    public void addListener(IListener listener)
    {
        listeners.Add(listener);
    }

    public void removeListeners(IListener listener)
    {
        listeners.Remove(listener);
    }

    public void notifyListeners()
    {
        foreach (var l in listeners) {
            l.update();
        }
    }
}