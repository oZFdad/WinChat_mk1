using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages.MessagesList
{
    public class TextMessage : Message
    {
        private string _text;
        public TextMessage(byte code, string name, string text) : base(code, name)
        {
            _text = text;
        }
    }
}
