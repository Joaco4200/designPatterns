public class SocketPaymentProcessorAdapter : IPaymentProcesor
{
    private SocketPaymentProcessor socketPaymentProcessor = new SocketPaymentProcessor();

    public void ProcessPayment(string username, double payment)
    {
        socketPaymentProcessor.ExecutePayment(username, payment);
    }
}