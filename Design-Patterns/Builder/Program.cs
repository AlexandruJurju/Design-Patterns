using Builder;
using Builder.Builders;

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());


director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());
