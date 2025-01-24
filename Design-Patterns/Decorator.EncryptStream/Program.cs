using Decorator.EncryptStream.Components;
using Decorator.EncryptStream.Decorators;

var data = "Hello World!";

CloudStream cloudStream = new CloudStreamSender();
cloudStream.Send(data);
Console.WriteLine();


CloudStream cloudStream2 = new CloudStreamSender();
cloudStream2 = new EncryptCloudStream(cloudStream2);
cloudStream2.Send(data);
Console.WriteLine();

CloudStream encryptedCompressedCloudStream = new EncryptCloudStream(new CompressCloudStream(new CloudStreamSender()));
encryptedCompressedCloudStream.Send(data);
Console.WriteLine();