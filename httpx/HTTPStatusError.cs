namespace PyException.httpx
{
    public class HTTPStatusError : HTTPError
    {
        public HttpResponseMessage Response { get; protected set; }

        public HTTPStatusError(string? message, HttpResponseMessage response) : base(message)
        {

        }
    }
}
