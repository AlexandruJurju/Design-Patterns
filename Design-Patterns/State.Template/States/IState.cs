namespace State.Template.States;

public interface IState
{
    void Handle(Context context);
}