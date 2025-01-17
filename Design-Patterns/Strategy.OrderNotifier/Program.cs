using Strategy.OrderNotifier;
using Strategy.OrderNotifier.Notifiers;

IOrderNotifier orderNotifier = new SmsService();

var order = new Order
{
    Id = 1,
    CustomerEmail = "test@test.com",
    CustomerPhone = "123456789",
    Status = OrderStatus.Delayed
};

var orderService = new OrderService(orderNotifier);
orderService.ShipOrder(order);

orderService._orderNotifier = new EmailService();
orderService.ShipOrder(order);

orderService._orderNotifier = new WhatsappService();
orderService.ShipOrder(order);