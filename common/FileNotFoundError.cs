namespace PyException.common
{
    public class FileNotFoundError : OSError
    {
        public FileNotFoundError(string message) : base(message)
        {
        }
    }
}
