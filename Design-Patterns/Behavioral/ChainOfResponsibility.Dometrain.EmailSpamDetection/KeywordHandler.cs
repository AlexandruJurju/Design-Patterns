namespace ChainOfResponsibility.Dometrain.EmailSpamDetection;

public class KeywordHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        if (ContainsSpamKeywords(email.Body) || ContainsSpamKeywords(email.Subject))
        {
            return true;
        }

        return _successor is not null && _successor.HandleSpamCheck(email);
    }

    private bool ContainsSpamKeywords(string text)
    {
        return text.ToLowerInvariant().Contains("spam");
    }
}