namespace Strategy.OrderNotifier.Notifiers;

public class EmailService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var subject = $"Order {order.Id} Shipped";
        var message = $"Order {order.Id} has been shipped";
        Send(subject, order.CustomerEmail, message);
    }
    
    public void Send(string subject, string orderCustomerEmail, string message)
    {
        Console.WriteLine($"Sending Email message with subject {subject} and body {message} to ${orderCustomerEmail} ");
    }
}