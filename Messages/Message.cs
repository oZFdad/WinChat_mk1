namespace Messages
{
    public abstract class Message
    {
        private byte _code;
        private string _name;

        public Message(byte code, string name)
        {
            _code = code;
            _name = name;
        }
    }
}