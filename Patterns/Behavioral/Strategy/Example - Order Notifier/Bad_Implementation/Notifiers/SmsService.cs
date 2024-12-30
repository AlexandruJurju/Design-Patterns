namespace Bad_Implementation.Notifiers;

public class SmsService
{
    public void Send(string orderCustomerPhone, string message)
    {
        Console.WriteLine($"Sending SMS message {message} to ${orderCustomerPhone} ");
    }
}