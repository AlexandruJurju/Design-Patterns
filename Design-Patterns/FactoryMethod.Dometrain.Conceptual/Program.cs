using FactoryMethod.Dometrain.Conceptual.Creators;
using FactoryMethod.Dometrain.Conceptual.Products;

Creator creator = new ConcreteCreator();

var concreteProduct = creator.CreateProduct();