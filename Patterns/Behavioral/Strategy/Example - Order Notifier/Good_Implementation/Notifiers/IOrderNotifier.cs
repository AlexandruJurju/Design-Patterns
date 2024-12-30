namespace Good_Implementation.Notifiers;

public interface IOrderNotifier
{
    void NotifyOrderShipped(Order order);
}