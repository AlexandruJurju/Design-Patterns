using Command.Remote.Receivers;

namespace Command.Remote.Commands;

public class GarageDoorCloseCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorCloseCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Down();
        _garageDoor.LightOff();
    }

    public void Undo()
    {
        _garageDoor.Up();
        _garageDoor.LightOn();
    }
}