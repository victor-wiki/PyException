namespace PyException.httpx
{
    public class ResponseNotRead : StreamError
    {
        public ResponseNotRead(string message) : base(message)
        {
        }
    }
}
