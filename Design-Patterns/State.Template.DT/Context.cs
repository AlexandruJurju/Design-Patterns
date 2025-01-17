﻿using State.Template.DT.States;

namespace State.Template.DT;

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