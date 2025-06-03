namespace Builder.FluentAction;

public class OrderBuilder
{
    private readonly AddressBuilder _addressBuilder = AddressBuilder.Create();
    private DateTime _createdOn;
    private int _number;

    private OrderBuilder()
    {
    }

    public static OrderBuilder Create()
    {
        return new OrderBuilder();
    }

    public OrderBuilder WithNumber(int number)
    {
        _number = number;
        return this;
    }

    public OrderBuilder CreatedOn(DateTime createdOn)
    {
        _createdOn = createdOn;
        return this;
    }

    public OrderBuilder WithShippingAddress(Action<AddressBuilder> action)
    {
        action(_addressBuilder);
        return this;
    }

    public Order Build()
    {
        return new Order
        {
            Number = _number,
            CreatedOn = _createdOn,
            ShippingAddress = _addressBuilder.Build()
        };
    }
}