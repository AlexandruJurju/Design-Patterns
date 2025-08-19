namespace State.States;

public interface IState
{
    void Handle(Context context);
}