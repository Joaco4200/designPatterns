public interface IAprover
{
    public void SetNext(IAprover next);
    public void Handle(Document doc);
}