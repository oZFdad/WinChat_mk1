using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TXTServices
{
    public class TXTTest : IService
    {
        public TXTTest()
        {

        }
        public void Pull(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("message catch");
        }
    }
}
