namespace Flyweight.Dometrain.Conceptual;

using Key = string;

public class FlyweightFactory
{
    private readonly Dictionary<Key, IFlyweight> _flyweights = [];

    public IFlyweight GetFlyweight(Key key)
    {
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new ConcreteFlyweight(intrinsicState: key);
        }

        return _flyweights[key];
    }
}