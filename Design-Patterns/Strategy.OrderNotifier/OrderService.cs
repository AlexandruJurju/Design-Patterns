using Strategy.OrderNotifier.Notifiers;

namespace Strategy.OrderNotifier;

public class OrderService
{
    public OrderService(IOrderNotifier orderNotifier)
    {
        _orderNotifier = orderNotifier;
    }

    public IOrderNotifier _orderNotifier { get; set; }

    public void ShipOrder(Order order)
    {
        order.Status = OrderStatus.Shipped;
        order.ShippedAt = DateTime.UtcNow;
        _orderNotifier.NotifyOrderShipped(order);
    }
}