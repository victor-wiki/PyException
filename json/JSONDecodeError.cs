using PyException.common;

namespace PyException.json
{
    public class JSONDecodeError : ValueError
    {
        public JSONDecodeError(string message) : base(message)
        {
        }
    }
}
