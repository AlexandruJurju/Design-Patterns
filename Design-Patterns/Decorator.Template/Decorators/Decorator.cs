using Decorator.Template.Components;

namespace Decorator.Template.Decorators;

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
        else
        {
            return string.Empty;
        }
    }
}