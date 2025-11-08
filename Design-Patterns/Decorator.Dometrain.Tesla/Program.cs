using Decorator.Dometrain.Tesla;

ITeslaModel3 car = new LongRangeWheelsDecorator(new BluePaintTeslaDecorator(new BasicTeslaModel3()));

Console.WriteLine(car.GetDescription());
Console.WriteLine(car.GetPrice());
Console.WriteLine(car.GetRange());