namespace State.Conceptual.States;

public interface IState
{
    void Handle(Context context);
}