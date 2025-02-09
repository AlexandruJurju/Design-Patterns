namespace ChainOfResponsibility;

public class DogHandler : AbstractHandler
{
    public override object? Handle(object request)
    {
        if (request.ToString() == "MeatBall")
        {
            return $"Dog: I'll eat the {request}\n";
        }

        return base.Handle(request);
    }
}