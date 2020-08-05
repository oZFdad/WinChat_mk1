using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatClient : Form
    {
        private TcpClient _connect;
        public ChatClient()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            var connectForm = new ConnectForm(_connect);
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
    }
}
