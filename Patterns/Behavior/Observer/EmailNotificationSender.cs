public class EmailNotificationSender: IListener{

    private List<string> emailAddresses = new List<string>();

    public void addEmail(string emailAddress)
    {
        emailAddresses.Add(emailAddress);
    }
    
    public void update() {
        Console.WriteLine("Email notification sent to: " + string.Join(", ", emailAddresses));
    }
}