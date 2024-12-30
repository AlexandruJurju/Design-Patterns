namespace Bad_Implementation.Notifiers;

public class EmailService
{
    public void Send(string subject, string orderCustomerEmail, string message)
    {
        Console.WriteLine($"Sending Email message with subject {subject} and body {message} to ${orderCustomerEmail} ");
    }
}