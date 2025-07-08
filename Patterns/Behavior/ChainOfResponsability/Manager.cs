public class Manager : BaseAprover
{
    public override void Handle(Document doc)
    {
        if (doc.ImportanceLevel <= 2)
            Console.WriteLine("Gerente aprobó el documento.");
        else if (next != null)
            next.Handle(doc);
    }
}