using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Additional_Forms
{
    class InviteForm : Form
    {
        private Button ntInvite;
        private Label lbInvite;
        private TextBox tbInvite;

        private void InitializeComponent()
        {
            this.ntInvite = new System.Windows.Forms.Button();
            this.lbInvite = new System.Windows.Forms.Label();
            this.tbInvite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ntInvite
            // 
            this.ntInvite.Location = new System.Drawing.Point(79, 64);
            this.ntInvite.Name = "ntInvite";
            this.ntInvite.Size = new System.Drawing.Size(100, 23);
            this.ntInvite.TabIndex = 0;
            this.ntInvite.Text = "Invite";
            this.ntInvite.UseVisualStyleBackColor = true;
            // 
            // lbInvite
            // 
            this.lbInvite.AutoSize = true;
            this.lbInvite.Location = new System.Drawing.Point(12, 41);
            this.lbInvite.Name = "lbInvite";
            this.lbInvite.Size = new System.Drawing.Size(61, 13);
            this.lbInvite.TabIndex = 1;
            this.lbInvite.Text = "Enter name";
            // 
            // tbInvite
            // 
            this.tbInvite.Location = new System.Drawing.Point(79, 38);
            this.tbInvite.Name = "tbInvite";
            this.tbInvite.Size = new System.Drawing.Size(100, 20);
            this.tbInvite.TabIndex = 2;
            // 
            // InviteForm
            // 
            this.ClientSize = new System.Drawing.Size(197, 109);
            this.Controls.Add(this.tbInvite);
            this.Controls.Add(this.lbInvite);
            this.Controls.Add(this.ntInvite);
            this.Name = "InviteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
