namespace PyException.httpx
{
    public class ConnectError : NetworkError
    {
        public ConnectError(string? message) : base(message)
        {
        }
    }
}
