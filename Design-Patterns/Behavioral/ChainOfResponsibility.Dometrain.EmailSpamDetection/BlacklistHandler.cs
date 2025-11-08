namespace ChainOfResponsibility.Dometrain.EmailSpamDetection;

public class BlacklistHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        if (email.Subject.Contains("prince"))
        {
            return true;
        }

        return _successor is not null && _successor.HandleSpamCheck(email);
    }
}