using Builder.Dometrain.Nested.Conceptual;

Product.Builder builder = new();

builder.BuildName("Name");
builder.BuildDescription("Description");

Product product = builder.Build();

Console.WriteLine(product);