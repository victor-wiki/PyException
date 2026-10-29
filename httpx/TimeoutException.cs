namespace PyException.httpx
{
    public class TimeoutException : TransportError
    {
        public TimeoutException(string? message) : base(message)
        {
        }
    }
}
