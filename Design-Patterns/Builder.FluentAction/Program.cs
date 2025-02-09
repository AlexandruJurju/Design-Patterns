using Builder.FluentAction;

Order order = OrderBuilder.Create()
    .CreatedOn(DateTime.Now)
    .WithNumber(1)
    .WithShippingAddress(address => address
        .Street("street")
        .City("city")
        .Zip("zip")
        .Country("country"))
    .Build();