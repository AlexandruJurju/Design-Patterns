using Good_Implementation.Notifiers;

namespace Good_Implementation;

public class OrderService
{
    public IOrderNotifier _orderNotifier { get; set; }

    public OrderService(IOrderNotifier orderNotifier)
    {
        _orderNotifier = orderNotifier;
    }

    public void ShipOrder(Order order)
    {
        order.Status = OrderStatus.Shipped;
        order.ShippedAt = DateTime.UtcNow;
        _orderNotifier.NotifyOrderShipped(order);
    }
}