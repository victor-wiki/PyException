namespace PyException.common
{
    public class IndexError : LookupError
    {
        public IndexError(string? message) : base(message)
        {
        }
    }
}
