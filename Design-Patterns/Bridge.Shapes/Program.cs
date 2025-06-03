using Bridge.Shapes.Abstraction;
using Bridge.Shapes.Implementation;

IColor red = new Red();
IColor blue = new Blue();

Shape redCircle = new Circle(red);
Shape blueSquare = new Square(blue);

redCircle.Draw();
blueSquare.Draw();