namespace PyException.httpx
{
    public class NetworkError : TransportError
    {
        public NetworkError(string? message) : base(message)
        {
        }
    }
}
