public class Program {
    public static void Main(string[] args)
    {
        //BUILDER PATTERNNN
        /*ISandwichBuilder builder= new SandwichBuilder();
        SandwichDirector director= new SandwichDirector(builder);
        director.MakeVeggieSandwich();
        Sandwich veggieSandwich= builder.GetResult();
        Console.WriteLine(veggieSandwich);*/

        //FACTORY METHOD PATTERNNN
        /*MessagingApp emailapp = new Sendemail();
        IMessage email = emailapp.SendMessage();
        email.Send();*/
        
        //PROTOTYPE PATTERNNN
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


        //OBSERVER PATTERNNN
        /*NotificationService notificationService = new NotificationService();
        EmailNotificationSender emailListener = new EmailNotificationSender();
        emailListener.addEmail("joacoaaar@gmail.com");
        SMSNotificationSender smsListener = new SMSNotificationSender();
        smsListener.AddPhoneNumber("098383474");

        notificationService.addListener(emailListener);
        notificationService.addListener(smsListener);
        notificationService.notifyListeners();*/

        //ADAPTER PATTERNNN
        /*IPaymentProcesor socketpayment = new SocketPaymentProcessorAdapter();
        IPaymentProcesor restpayment = new RestPaymentProcessorAdapter();

        socketpayment.ProcessPayment("juan", 10.0);
        restpayment.ProcessPayment("rodrigo", 90.0);*/

        //MEMENTO PATERNN
        /*UserProfile userProfile = new UserProfile("John Doe", 30);
        UserProfileHistory history = new UserProfileHistory();

        history.Save(userProfile.Save()); // Guardar el "memento" actual de userProfile.
        userProfile.PrintProfile();

        userProfile.name = "Jose Doe";
        userProfile.age = 25; 
        history.Save(userProfile.Save());

        userProfile.Restore(history.Undo());
        userProfile.PrintProfile();*/

        //CHAIN OF RESPONSABILITY PATTERNNN
        /*Document doc = new Document("Informe Anual", 2);

        Director director = new Director();
        Manager manager = new Manager();
        Employee employee = new Employee();

        employee.SetNext(manager);
        manager.SetNext(director);

        employee.Handle(doc);*/

        //DECORATOR PATTERNNN
        /*IMarleyMachine marleyMachine = new MarleyMachine();
        marleyMachine.ShowPrice();
        IMarleyMachine coffewithMilk = new MilkDecorator(marleyMachine);
        coffewithMilk.ShowPrice();*/



        //STRATEGY PATTERNNN
        /*var employeeManager = new EmployeeManager();

        employeeManager.AddEmployee(new Employee { Name = "Lala", HoursWorked = 40, HourlyRate = 25 });
        employeeManager.AddEmployee(new Employee { Name = "Pepe", HoursWorked = 50, HourlyRate = 20 });

        // Se elige la estrategia a usar
        employeeManager.SetPayrollStrategy(new OvertimePayroll());

        Console.WriteLine("Total Payroll: $" + employeeManager.CalculateTotalPayroll());

        // Se puede cambiar la estrategia en tiempo de ejecución si se desea
        employeeManager.SetPayrollStrategy(new StandardPayroll());
        employeeManager.AddEmployee(new Employee { Name = "Boss", HoursWorked = 5, HourlyRate = 200 });

        Console.WriteLine("Recalculated Payroll: $" + employeeManager.CalculateTotalPayroll());*/

    }   
}