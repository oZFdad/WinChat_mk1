namespace Messages
{
    public abstract class Message
    {
        private byte _code;

        public Message(byte code)
        {
            _code = code;
        }

        public void Process()
        {
            
        }
    }
}