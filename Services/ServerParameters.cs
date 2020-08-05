using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServerParameters
    {
        public static string GetIPAdr()
        {
            return "127.0.0.1"; // ip адрес для прослушивания
        }

        public static int GetPort()
        {
            return 8888; // порт прослушки
        }


    }
}
