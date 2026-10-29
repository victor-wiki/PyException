namespace PyException.common
{
    public class EnvironmentError: OSError
    {
        public EnvironmentError(string message) : base(message) { }
    }
}
