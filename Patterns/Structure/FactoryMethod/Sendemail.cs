public class Sendemail : MessagingApp
{
    public override IMessage SendMessage() {
        return new Email();
    }
}