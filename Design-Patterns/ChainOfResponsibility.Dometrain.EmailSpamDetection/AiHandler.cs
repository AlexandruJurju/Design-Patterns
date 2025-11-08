namespace ChainOfResponsibility.Dometrain.EmailSpamDetection;

public class AiHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        Random random = new Random();

        if (random.Next(100) < 50)
        {
            return true;
        }

        return _successor is not null && _successor.HandleSpamCheck(email);
    }
}