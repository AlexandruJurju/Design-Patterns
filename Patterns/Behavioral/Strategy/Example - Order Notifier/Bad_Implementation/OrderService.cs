using Bad_Implementation.Notifiers;

namespace Bad_Implementation;

public class OrderService
{
    private readonly EmailService _emailService;
    private readonly SmsService _smsService;
    private readonly WhatsappService _whatsappService;

    public OrderService(EmailService emailService, SmsService smsService, WhatsappService whatsappService)
    {
        _emailService = emailService;
        _smsService = smsService;
        _whatsappService = whatsappService;
    }

    public void ShipOrder(NotificationType programNotification, Order order)
    {
        order.Status = OrderStatus.Shipped;
        order.ShippedAt = DateTime.UtcNow;

        // bad if blocks, need to change if i want to add another service
        if (programNotification == NotificationType.Email)
        {
            var subject = $"Order {order.Id} Shipped";
            var message = $"Order {order.Id} has been shipped";
            _emailService.Send(subject, order.CustomerEmail, message);
        }

        if (programNotification == NotificationType.Sms)
        {
            var message = $"Order {order.Id} has been shipped";
            _smsService.Send(order.CustomerPhone, message);
        }
        
        if (programNotification == NotificationType.Whatsapp)
        {
            var message = $"Order {order.Id} has been shipped";
            _whatsappService.Send(order.CustomerPhone, message);
        }
    }
}