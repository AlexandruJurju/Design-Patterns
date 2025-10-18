using Builder.Dometrain.Conceptual;
using Builder.Dometrain.Conceptual.Builders;

IBuilder builder = new ComplexProductBuilder();

builder.BuildName();
builder.BuildDescription();

Product product = builder.Build();

Console.WriteLine(product);