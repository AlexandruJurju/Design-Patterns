using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class GarageDoorOpenCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Up();
        _garageDoor.LightOn();
    }

    public void Undo()
    {
        _garageDoor.Down();
        _garageDoor.LightOff();
    }
}