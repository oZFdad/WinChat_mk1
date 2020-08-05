using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Logic
{
    public class UserConnect
    {
        private TcpClient _client;
        private IService _service;

        public UserConnect(TcpClient tcpClient, IService service)
        {
            _client = tcpClient;
            _service = service;
        }

        public void Process()
        {
            NetworkStream stream = null;

            try
            {
                stream = _client.GetStream();
                byte[] data = new byte[256]; 
                while (true)
                {
                    
                    var builder = new StringBuilder();
                    var bytes = 0;
                    while (stream.DataAvailable)
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }

                    

                    string message = builder.ToString();

                    if (message != "")
                    {
                        _service.Pull(message);
                    }

                    if (message == "Close")
                    {
                        _client.Close();
                        Console.WriteLine("Client disconnect");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (_client != null)
                    _client.Close();
                Console.WriteLine("Client disconnect");
            }
        }
    }
}
