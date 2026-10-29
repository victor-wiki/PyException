namespace PyException.common
{
    public class BlockingIOError : OSError
    {
        public BlockingIOError(string message) : base(message)
        {
        }
    }
}
