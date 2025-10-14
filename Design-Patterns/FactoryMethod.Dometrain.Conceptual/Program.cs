using FactoryMethod.Dometrain.Conceptual.Creators;
using FactoryMethod.Dometrain.Conceptual.Products;

Creator creator = new ConcreteCreator();

IProduct concreteProduct = creator.CreateProduct();