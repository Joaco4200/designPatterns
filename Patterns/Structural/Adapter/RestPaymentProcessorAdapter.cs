public class RestPaymentProcessorAdapter : IPaymentProcesor
{
    private RestPaymentProcessor restPaymentProcessor = new RestPaymentProcessor();

    public void ProcessPayment(string username, double payment)
    {
        restPaymentProcessor.MakePayment(username, payment);
    }
}