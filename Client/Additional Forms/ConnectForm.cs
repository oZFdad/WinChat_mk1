using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal class ConnectForm : Form
    {
        private TcpClient _connect;
        
        private Button _btConnect; // кнока подключения
        private Button _btClose; // кнопка закрытия окна

        private Label _lbIPAdr; // лейбл поля ввода ip
        private Label _lbPort; // лейбл поля ввода порта

        private TextBox _tbIPAdr;// поле ввода ip
        private TextBox _tbPort;// поле ввода порта

        public ConnectForm(TcpClient connect)
        {
            _connect = connect;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this._btConnect = new System.Windows.Forms.Button();
            this._btClose = new System.Windows.Forms.Button();
            this._lbIPAdr = new System.Windows.Forms.Label();
            this._lbPort = new System.Windows.Forms.Label();
            this._tbIPAdr = new System.Windows.Forms.TextBox();
            this._tbPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btConnect
            // 
            this._btConnect.Location = new System.Drawing.Point(47, 98);
            this._btConnect.Name = "_btConnect";
            this._btConnect.Size = new System.Drawing.Size(65, 20);
            this._btConnect.TabIndex = 3;
            this._btConnect.Text = "Connect";
            this._btConnect.UseVisualStyleBackColor = true;
            this._btConnect.Click += new System.EventHandler(this._btConnectClick);
            // 
            // _btClose
            // 
            this._btClose.Location = new System.Drawing.Point(187, 98);
            this._btClose.Name = "_btClose";
            this._btClose.Size = new System.Drawing.Size(65, 20);
            this._btClose.TabIndex = 4;
            this._btClose.Text = "Close";
            this._btClose.UseVisualStyleBackColor = true;
            this._btClose.Click += new System.EventHandler(this._btCloseClick);
            // 
            // _lbIPAdr
            // 
            this._lbIPAdr.AutoSize = true;
            this._lbIPAdr.Location = new System.Drawing.Point(12, 18);
            this._lbIPAdr.Name = "_lbIPAdr";
            this._lbIPAdr.Size = new System.Drawing.Size(48, 13);
            this._lbIPAdr.TabIndex = 5;
            this._lbIPAdr.Text = "ip адрес";
            // 
            // _lbPort
            // 
            this._lbPort.AutoSize = true;
            this._lbPort.Location = new System.Drawing.Point(12, 63);
            this._lbPort.Name = "_lbPort";
            this._lbPort.Size = new System.Drawing.Size(30, 13);
            this._lbPort.TabIndex = 6;
            this._lbPort.Text = "порт";
            // 
            // _tbIPAdr
            // 
            this._tbIPAdr.Location = new System.Drawing.Point(70, 18);
            this._tbIPAdr.Name = "_tbIPAdr";
            this._tbIPAdr.Size = new System.Drawing.Size(200, 20);
            this._tbIPAdr.TabIndex = 1;
            this._tbIPAdr.Text = "127.0.0.1";
            // 
            // _tbPort
            // 
            this._tbPort.Location = new System.Drawing.Point(70, 60);
            this._tbPort.Name = "_tbPort";
            this._tbPort.Size = new System.Drawing.Size(200, 20);
            this._tbPort.TabIndex = 2;
            this._tbPort.Text = "8888";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 131);
            this.Controls.Add(this._btConnect);
            this.Controls.Add(this._lbIPAdr);
            this.Controls.Add(this._lbPort);
            this.Controls.Add(this._tbIPAdr);
            this.Controls.Add(this._tbPort);
            this.Controls.Add(this._btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectForm";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _btConnectClick (object sender, EventArgs e)
        {
            var name = "TestName";

            try
            {
                _connect = new TcpClient(_tbIPAdr.Text, Convert.ToInt32(_tbPort.Text));
                var stream = _connect.GetStream();

                var message = $"{name}: test message!";
                
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                
                Thread.Sleep(4000);
                
                message = "Close";
                
                data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch
            {

            }
            finally
            {
                Close();
            }
        }

        private void _btCloseClick (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
