namespace PyException.common
{
    public class ConnectionAbortedError : ConnectionError
    {
        public ConnectionAbortedError(string message) : base(message)
        {
        }
    }
}
