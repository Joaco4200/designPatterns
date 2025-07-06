public class SMSListener
{
    private List<string> phoneNumbers = new List<string>();
    public void AddPhoneNumber(string phoneNumber)
    {
        phoneNumbers.Add(phoneNumber);
    }
    public void SendMessage(string phoneNumber, string message)
    {
        foreach (var phone in phoneNumbers)
        {
            Console.WriteLine($"Sending SMS to {phone}: {message}");
        }
    }
}