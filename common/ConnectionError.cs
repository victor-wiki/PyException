namespace PyException.common
{
    public class ConnectionError : OSError
    {
        public ConnectionError(string message) : base(message)
        {
        }
    }
}
