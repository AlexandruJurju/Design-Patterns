namespace State;

public interface IState
{
    void Handle(Context context);
}