namespace Bad_Implementation.Notifiers;

public class WhatsappService
{
    public void Send(string orderCustomerPhone, string message)
    {
        Console.WriteLine($"Sending Whatsapp message {message} to ${orderCustomerPhone} ");
    }
}