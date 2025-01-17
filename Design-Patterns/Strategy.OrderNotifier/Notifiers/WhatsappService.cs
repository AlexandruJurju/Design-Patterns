namespace Strategy.OrderNotifier.Notifiers;

public class WhatsappService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var message = $"Order {order.Id} has been shipped";
        Send(order.CustomerPhone, message);
    }

    public void Send(string orderCustomerPhone, string message)
    {
        Console.WriteLine($"Sending Whatsapp message {message} to ${orderCustomerPhone} ");
    }
}