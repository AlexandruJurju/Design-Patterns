using Builder.Nested;

var product = new Product.Builder()
    .AddPartA()
    .AddPartB()
    .Build();

product.Show();