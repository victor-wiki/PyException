namespace PyException.common
{
    public class ConnectionResetError : ConnectionError
    {
        public ConnectionResetError(string message) : base(message)
        {
        }
    }
}
