public class Sendfacebooksms : MessagingApp
{
    public override IMessage SendMessage() {
        return new Facebooksms();
    }
}