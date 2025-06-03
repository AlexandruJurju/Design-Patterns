using Command.Remote.Commands;

namespace Command.Remote.Invokers;

public class RemoteControls
{
    private ICommand _slot;

    public void SetCommand(ICommand command)
    {
        _slot = command;
    }

    public void PressButton()
    {
        _slot.Execute();
    }
}