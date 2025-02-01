using FactoryMethod.Creators;

var creator1 = new ConcreteCreator1();
var result1 = creator1.SomeOperation();
Console.WriteLine(result1);

var creator2 = new ConcreteCreator2();
var result2 =creator2.SomeOperation();
Console.WriteLine(result2);