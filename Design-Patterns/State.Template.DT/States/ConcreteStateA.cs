namespace State.Template.DT.States;

public class ConcreteStateA: IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateA handles the request");
        
        context.SetState(new ConcreteStateB());
    }
}