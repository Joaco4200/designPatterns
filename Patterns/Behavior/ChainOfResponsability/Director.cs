public class Director : BaseAprover
{
    public override void Handle(Document doc)
    {
        if (doc.ImportanceLevel <= 3) {
         Console.WriteLine("Director aprobó el documento.");   
        }
        else if (next != null)
        {
            next.Handle(doc);   
        }
    }
}