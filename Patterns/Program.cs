using Builder;
public class Program {
    public static void Main(string[] args)
    {
        /*ISandwichBuilder builder= new SandwichBuilder();
        SandwichDirector director= new SandwichDirector(builder);
        director.MakeVeggieSandwich();
        Sandwich veggieSandwich= builder.GetResult();
        Console.WriteLine(veggieSandwich);*/

        /*Book originalBook = new Book
        {
            Title = "Harry Potter",
            Author = "J.K. Rowling"
        };
       originalBook.BorrowBook("Alice");
        originalBook.BorrowBook("Bob");
        originalBook.PrintBorrowedStudents();

        // Clonar el libro
        Book clonedBook = originalBook.Clone();
        clonedBook.BorrowBook("Charlie");
        clonedBook.PrintBorrowedStudents();

        // Imprimir los estudiantes que han tomado prestado el libro original
        originalBook.PrintBorrowedStudents();*/

        var emailSystem = new EmailNotificationSystem();
        var smsSystem = new SMSNotificationSystem();
        var message = "This is a notification message.";
        // Simulate subscribing users
        emailSystem.Subscribe("user1@example.com");
        smsSystem.AddPhoneNumber("123-456-7890");
        // Simulate sending notifications
        emailSystem.SendEmail(message);
        smsSystem.SendMessage(message);
   }   
}