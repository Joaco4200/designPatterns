public class NotificationService
{
    private List<IListener> listeners;
    public NotificationService()
    {
        listeners = new ArrayList<>();
    }

    public void addListener(Listeners listener)
    {
        observers.add(listener);
    }

    public void removeListeners(Listeners listener)
    {
        observers.remove(listener);
    }

    public void notifyListeners()
    {
        foreach (listeners l in listeners) {
            l.update();
        }
    }
}