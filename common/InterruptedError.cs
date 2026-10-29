namespace PyException.common
{
    public class InterruptedError : OSError
    {
        public InterruptedError(string message) : base(message)
        {
        }
    }
}
