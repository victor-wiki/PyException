namespace PyException.common
{
    public class KeyError: LookupError
    {
        public KeyError(string message) : base(message) { }
    }
}
