public class SMSNotificationSender: IListener
{
    private List<string> phoneNumbers = new List<string>();
    public void AddPhoneNumber(string phoneNumber)
    {
        phoneNumbers.Add(phoneNumber);
    }
    public void update()
    {
        Console.WriteLine("SMS notification senttt to: " + string.Join(", ", phoneNumbers));
    }
}