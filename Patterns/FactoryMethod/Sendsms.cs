public class Sendsms : MessagingApp
{
    public override IMessage SendMessage() {
        return new Sms();
    }
}