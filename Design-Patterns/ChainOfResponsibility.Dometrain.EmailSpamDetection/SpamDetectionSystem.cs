namespace ChainOfResponsibility.Dometrain.EmailSpamDetection;

public class SpamDetectionSystem
{
    private readonly SpamHandler _chain;

    public SpamDetectionSystem()
    {
        _chain = new KeywordHandler();
        var blackListHandler = new BlacklistHandler();
        var mlHandler = new AiHandler();

        _chain.SetSuccessor(blackListHandler);
        blackListHandler.SetSuccessor(mlHandler);
    }

    public bool CheckForSpam(Email email)
    {
        return _chain.HandleSpamCheck(email);
    }
}