using Decorator.Conceptual.Components;

namespace Decorator.Conceptual.Decorators;

public abstract class Decorator : Component
{
    protected Component? _component;

    protected Decorator(Component component)
    {
        _component = component;
    }

    public void SetComponent(Component component)
    {
        _component = component;
    }

    public override string Operation()
    {
        if (_component != null)
        {
            return _component.Operation();
        }

        return string.Empty;
    }
}