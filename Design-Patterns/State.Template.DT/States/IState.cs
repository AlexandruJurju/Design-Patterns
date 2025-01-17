namespace State.Template.DT.States;

public interface IState
{
    void Handle(Context context);
}