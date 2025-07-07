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



        /*NotificationService notificationService = new NotificationService();
        EmailNotificationSender emailListener = new EmailNotificationSender();
        emailListener.addEmail("joacoaaar@gmail.com");
        SMSNotificationSender smsListener = new SMSNotificationSender();
        smsListener.AddPhoneNumber("098383474");

        notificationService.addListener(emailListener);
        notificationService.addListener(smsListener);
        notificationService.notifyListeners();*/

        IPaymentProcesor socketpayment = new SocketPaymentProcessorAdapter();
        IPaymentProcesor restpayment = new RestPaymentProcessorAdapter();

        socketpayment.ProcessPayment("juan", 10.0);
        restpayment.ProcessPayment("rodrigo", 90.0);
   }   
}