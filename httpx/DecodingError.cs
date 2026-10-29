namespace PyException.httpx
{
    public class DecodingError : RequestError
    {
        public DecodingError(string? message) : base(message)
        {
        }
    }
}
