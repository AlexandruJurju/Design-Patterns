using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
{
    public void Execute()
    {
        garageDoor.Up();
        garageDoor.LightOn();
    }

    public void Undo()
    {
        garageDoor.Down();
        garageDoor.LightOff();
    }
}