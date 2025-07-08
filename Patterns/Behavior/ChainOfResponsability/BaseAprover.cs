public abstract class BaseAprover : IAprover
{
    protected IAprover next;
    public void SetNext(IAprover handler)
    {
        this.next = handler;
    }
    public abstract void Handle(Document doc);
}