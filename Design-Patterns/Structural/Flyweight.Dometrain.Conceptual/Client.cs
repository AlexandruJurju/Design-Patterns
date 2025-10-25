namespace Flyweight.Dometrain.Conceptual;
using Key = string;

public class Client(FlyweightFactory factory)
{
   public void Operation(string extrinsicState)
   {
      Key key = extrinsicState[0].ToString();

      IFlyweight flyweight1 = factory.GetFlyweight(key);

      flyweight1.Operation(extrinsicState);
   }
}