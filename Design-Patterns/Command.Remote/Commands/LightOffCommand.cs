using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.Off();
    }

    public void Undo()
    {
        light.On();
    }
}