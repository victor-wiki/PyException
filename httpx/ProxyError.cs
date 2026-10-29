namespace PyException.httpx
{
    public class ProxyError : TransportError
    {
        public ProxyError(string? message) : base(message)
        {
        }
    }
}
