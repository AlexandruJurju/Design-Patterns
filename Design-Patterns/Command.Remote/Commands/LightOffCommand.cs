﻿using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.Off();

    public void Undo() => _light.On();
}