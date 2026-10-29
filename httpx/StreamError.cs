using PyException.common;

namespace PyException.httpx
{
    public class StreamError : RuntimeError
    {
        public StreamError(string message) : base(message)
        {
        }
    }
}
