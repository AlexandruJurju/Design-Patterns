using Builder.StaticInner;

var product = new Product.Builder()
    .AddPartA()
    .AddPartB()
    .Build();

product.Show();