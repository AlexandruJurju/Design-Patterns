namespace Command.Conceptual;

internal class Invoker
{
    private ICommand? _onFinish;
    private ICommand? _onStart;

    public void SetOnStart(ICommand command)
    {
        _onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        _onFinish = command;
    }

    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        if (_onStart != null) _onStart.Execute();

        Console.WriteLine("Invoker: ...doing something really important...");

        Console.WriteLine("Invoker: Does anybody want something done after I finish?");
        if (_onFinish != null) _onFinish.Execute();
    }
}