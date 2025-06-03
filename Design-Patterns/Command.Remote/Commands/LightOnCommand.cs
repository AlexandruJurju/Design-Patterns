using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class LightOnCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}