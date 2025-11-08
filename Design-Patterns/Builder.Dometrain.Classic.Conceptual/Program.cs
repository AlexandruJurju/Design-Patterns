using Builder.Dometrain.Classic.Conceptual;
using Builder.Dometrain.Classic.Conceptual.Builders;

IBuilder builder = new ComplexProductBuilder();

ProductDirector direct = new ProductDirector(builder);

direct.ConstructProduct();

Product product = builder.Build();
Console.WriteLine(product);