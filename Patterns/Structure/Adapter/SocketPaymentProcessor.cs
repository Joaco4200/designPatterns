public class SocketPaymentProcessor
{
    public void ExecutePayment(string username, double payment)
    {
        Console.WriteLine($"Executing payment for {username} through legacy socket - based system: ${ payment} ");
    }
}