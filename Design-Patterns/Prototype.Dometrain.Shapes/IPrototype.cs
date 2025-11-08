namespace Prototype.Dometrain.Shapes;

public interface IPrototype<out T>
{
    T Clone();
}