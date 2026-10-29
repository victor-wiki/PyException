namespace PyException.common
{
    public class FileExistsError : OSError
    {
        public FileExistsError(string message) : base(message)
        {
        }
    }
}
