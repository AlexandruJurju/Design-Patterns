using Builder.Conceptual;
using Builder.Conceptual.Builders;

var director = new Director();
// heavy instantiation of the builder -> easier as a static class
var builder = new ConcreteBuilder();
director.Builder = builder;

director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());


director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());