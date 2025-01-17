using State.Template.States;

namespace State.Template;

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }
}