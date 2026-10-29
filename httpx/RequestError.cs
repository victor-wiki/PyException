namespace PyException.httpx
{
    public class RequestError : HTTPError
    {
        public RequestError(string? message) : base(message)
        {
        }
    }
}
