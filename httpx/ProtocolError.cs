namespace PyException.httpx
{
    public class ProtocolError : TransportError
    {
        public ProtocolError(string? message) : base(message)
        {
        }
    }
}
