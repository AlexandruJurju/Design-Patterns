namespace Command.Remote.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}