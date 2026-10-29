namespace PyException.httpx
{
    public class LocalProtocolError : ProtocolError
    {
        public LocalProtocolError(string? message) : base(message)
        {
        }
    }
}
