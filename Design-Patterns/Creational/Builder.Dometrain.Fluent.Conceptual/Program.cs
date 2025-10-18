using Builder.Dometrain.Fluent.Conceptual;

Product product = new Product.Builder()
    .SetDescription("Fluent Description")
    .SetName("Fluent Name")
    .Build();

Console.WriteLine(product);