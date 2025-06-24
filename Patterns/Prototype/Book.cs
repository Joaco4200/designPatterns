public class Book : IPrototype<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public List<string> BorrowedStudents { get; set; }

    public Book()
    {
        // Simular la carga de recursos.
        Console.WriteLine("Acquiring a new book...");
        BorrowedStudents = new List<string>();
    }
    public void BorrowBook(string studentName)
    {
        BorrowedStudents.Add(studentName);
    }
    public void PrintBorrowedStudents()
    {
        Console.WriteLine($"Book: {Title}, Borrowed by: {string.Join(", ",
        BorrowedStudents)}");
    }

    public Book Clone()
    {
        // Crear una copia superficial del libro.
        return new Book
        {
            Title = this.Title,
            Author = this.Author,
            BorrowedStudents = new List<string>(this.BorrowedStudents)
        };
    }
}