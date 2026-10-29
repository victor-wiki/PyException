namespace PyException.httpx
{
    public class HTTPError : Exception
    {
        public HTTPError(string? message) : base(message)
        {
        }
    }
}
