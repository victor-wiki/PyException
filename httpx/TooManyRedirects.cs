namespace PyException.httpx
{
    public class TooManyRedirects: RequestError
    {
        public TooManyRedirects(string message) : base(message) { }
    }
}
