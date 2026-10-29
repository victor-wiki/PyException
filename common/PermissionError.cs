namespace PyException.common
{
    public class PermissionError : OSError
    {
        public PermissionError(string message) : base(message)
        {
        }
    }
}
