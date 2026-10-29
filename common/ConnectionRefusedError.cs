namespace PyException.common
{
    public class ConnectionRefusedError : ConnectionError
    {
        public ConnectionRefusedError(string message) : base(message)
        {
        }
    }
}
