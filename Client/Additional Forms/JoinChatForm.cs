using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Additional_Forms
{
    class JoinChatForm : Form
    {
        private Button btJoinChat;
        private Label lbJoinChat;
        private TextBox tbJoinChat;

        private void InitializeComponent()
        {
            this.btJoinChat = new System.Windows.Forms.Button();
            this.lbJoinChat = new System.Windows.Forms.Label();
            this.tbJoinChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btJoinChat
            // 
            this.btJoinChat.Location = new System.Drawing.Point(116, 58);
            this.btJoinChat.Name = "btJoinChat";
            this.btJoinChat.Size = new System.Drawing.Size(100, 23);
            this.btJoinChat.TabIndex = 0;
            this.btJoinChat.Text = "Join";
            this.btJoinChat.UseVisualStyleBackColor = true;
            // 
            // lbJoinChat
            // 
            this.lbJoinChat.AutoSize = true;
            this.lbJoinChat.Location = new System.Drawing.Point(25, 35);
            this.lbJoinChat.Name = "lbJoinChat";
            this.lbJoinChat.Size = new System.Drawing.Size(85, 13);
            this.lbJoinChat.TabIndex = 1;
            this.lbJoinChat.Text = "Enter chat name";
            // 
            // tbJoinChat
            // 
            this.tbJoinChat.Location = new System.Drawing.Point(116, 32);
            this.tbJoinChat.Name = "tbJoinChat";
            this.tbJoinChat.Size = new System.Drawing.Size(100, 20);
            this.tbJoinChat.TabIndex = 2;
            // 
            // JoinChatForm
            // 
            this.ClientSize = new System.Drawing.Size(231, 106);
            this.Controls.Add(this.tbJoinChat);
            this.Controls.Add(this.lbJoinChat);
            this.Controls.Add(this.btJoinChat);
            this.Name = "JoinChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
