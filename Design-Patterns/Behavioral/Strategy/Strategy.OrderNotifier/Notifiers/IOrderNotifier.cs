namespace Strategy.OrderNotifier.Notifiers;

public interface IOrderNotifier
{
    void NotifyOrderShipped(Order order);
}