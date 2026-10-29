namespace PyException.common
{
    public class TimeoutError : OSError
    {
        public TimeoutError(string message) : base(message)
        {
        }
    }
}
