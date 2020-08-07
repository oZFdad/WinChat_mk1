using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatClient : Form
    {
        private TcpClient _connect = null;
        public ChatClient()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            var connectForm = new ConnectForm();
            connectForm.connect += CreateTCPconnect;
            connectForm.Show();
        }

        private void btCreateChat_Click(object sender, EventArgs e)
        {
            var a = 0;
        }

        private void btJoinChat_Click(object sender, EventArgs e)
        {

        }

        private void btQuitChat_Click(object sender, EventArgs e)
        {

        }

        private void btSendMess_Click(object sender, EventArgs e)
        {

        }

        private void ChatClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CreateTCPconnect (string ipAdr, int port)
        {

            var name = "TestName";

            try
            {

                _connect = new TcpClient(ipAdr, port);
                var stream = _connect.GetStream();
                
                var message = $"{name}: test message!";
                
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                //Thread.Sleep(4000);
                //
                //message = "Close";
                //
                //data = Encoding.Unicode.GetBytes(message);
                //stream.Write(data, 0, data.Length);
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к серверу", "Внимание!");
            }
            finally
            {
                
            }
        }
    }
}
