namespace ChainOfResponsibility.Iluwatar.OrcKing;

public class Request(RequestType requestType, string description)
{
    public RequestType RequestType { get; set; } = requestType;
    public string Description { get; set; } = description;
    public bool Handled { get; set; } = false;
}
