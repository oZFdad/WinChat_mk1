using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Additional_Forms
{
    class CreatChatForm : Form
    {
        private Button btCreateChat;
        private TextBox tbCreateChat;
        private Label lbCreateChat;

        private void InitializeComponent()
        {
            this.btCreateChat = new System.Windows.Forms.Button();
            this.tbCreateChat = new System.Windows.Forms.TextBox();
            this.lbCreateChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreateChat
            // 
            this.btCreateChat.Location = new System.Drawing.Point(118, 67);
            this.btCreateChat.Name = "btCreateChat";
            this.btCreateChat.Size = new System.Drawing.Size(100, 23);
            this.btCreateChat.TabIndex = 0;
            this.btCreateChat.Text = "Create";
            this.btCreateChat.UseVisualStyleBackColor = true;
            // 
            // tbCreateChat
            // 
            this.tbCreateChat.Location = new System.Drawing.Point(118, 41);
            this.tbCreateChat.Name = "tbCreateChat";
            this.tbCreateChat.Size = new System.Drawing.Size(100, 20);
            this.tbCreateChat.TabIndex = 1;
            // 
            // lbCreateChat
            // 
            this.lbCreateChat.AutoSize = true;
            this.lbCreateChat.Location = new System.Drawing.Point(27, 44);
            this.lbCreateChat.Name = "lbCreateChat";
            this.lbCreateChat.Size = new System.Drawing.Size(85, 13);
            this.lbCreateChat.TabIndex = 2;
            this.lbCreateChat.Text = "Enter name chat";
            // 
            // CreatChatForm
            // 
            this.ClientSize = new System.Drawing.Size(237, 112);
            this.Controls.Add(this.lbCreateChat);
            this.Controls.Add(this.tbCreateChat);
            this.Controls.Add(this.btCreateChat);
            this.Name = "CreatChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
