using System.Text;
using Decorator.EncryptStream.Components;

namespace Decorator.EncryptStream.Decorators;

public class EncryptCloudStream : Decorator
{
    public EncryptCloudStream(CloudStream decoratedStream) : base(decoratedStream)
    {
    }

    public override void Send(string data)
    {
        var encryptedData = Encrypt(data);
        _decoratedStream.Send(encryptedData);
    }

    private string Encrypt(string data)
    {
        var stringBuilder = new StringBuilder();
        var random = new Random();

        foreach (var character in data)
        {
            switch (random.Next(0, 4))
            {
                case 0:
                    stringBuilder.Append(character);
                    break;
                case 1:
                    stringBuilder.Append("$");
                    break;
                case 2:
                    stringBuilder.Append("@");
                    break;
                case 3:
                    stringBuilder.Append("%");
                    break;
            }
        }

        return stringBuilder.ToString();
    }
}