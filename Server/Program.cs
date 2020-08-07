using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Logic;
using Services;
using Services.TXTServices;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Parse(ServerParameters.GetIPAdr()), ServerParameters.GetPort());
                listener.Start();
                Console.WriteLine("Ожидание подключений...");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    var userConnect = new UserConnect(client, new TXTTest());
                    
                    //process.AddConnect


                    Thread clientThread = new Thread(new ThreadStart(userConnect.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }
    }
}
