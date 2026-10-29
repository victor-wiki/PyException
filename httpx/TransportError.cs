namespace PyException.httpx
{
    public class TransportError : HTTPError
    {
        public TransportError(string? message) : base(message)
        {
        }
    }
}
