namespace Decorator.LowercaseStream;

public class LowerCaseStream : Stream
{
    private readonly Stream _baseStream;

    public LowerCaseStream(Stream baseStream)
    {
        _baseStream = baseStream;
    }

    public override bool CanRead => _baseStream.CanRead;
    public override bool CanSeek => _baseStream.CanSeek;
    public override bool CanWrite => _baseStream.CanWrite;
    public override long Length => _baseStream.Length;

    public override long Position
    {
        get => _baseStream.Position;
        set => _baseStream.Position = value;
    }

    public override void Flush()
    {
        _baseStream.Flush();
    }

    // Overridden to read the text in lowercase
    public override int Read(byte[] buffer, int offset, int count)
    {
        // Read data from the base stream
        var bytesRead = _baseStream.Read(buffer, offset, count);

        // Convert the read bytes to lowercase
        for (var i = offset; i < offset + bytesRead; i++)
        {
            buffer[i] = (byte)char.ToLower((char)buffer[i]);
        }

        return bytesRead;
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        return _baseStream.Seek(offset, origin);
    }

    public override void SetLength(long value)
    {
        _baseStream.SetLength(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        _baseStream.Write(buffer, offset, count);
    }
}