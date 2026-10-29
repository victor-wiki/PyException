namespace PyException.httpx
{
    public class RemoteProtocolError : ProtocolError
    {
        public RemoteProtocolError(string? message) : base(message)
        {
        }
    }
}
