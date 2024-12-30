namespace Observer.Subject;

public class ConcreteSubject
{
    public event ValueChangedEventArgs ValueChangedEvent;
    public int State { get; set; } = 0;

    public void ChangeState()
    {
        State = new Random().Next(0, 100);
        OnValueChanged(State);
    }

    protected virtual void OnValueChanged(int state)
    {
        ValueChangedEvent?.Invoke(state);
    }
}