namespace PyException.common
{
    public class NotImplementedError : RuntimeError
    {
        public NotImplementedError(string message) : base(message)
        {
        }
    }
}
