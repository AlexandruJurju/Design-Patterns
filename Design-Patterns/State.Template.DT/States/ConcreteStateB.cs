namespace State.Template.DT.States;

public class ConcreteStateB: IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateB handles the request");
        
        context.SetState(new ConcreteStateA());
    }
}