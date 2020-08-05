using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Additional_Forms
{
    class AuthorizationForm : Form
    {
        private TextBox tbEnterName;
        private Label lbEnterName;
        private Button btAuthorizate;

        private void InitializeComponent()
        {
            this.btAuthorizate = new System.Windows.Forms.Button();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.lbEnterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAuthorizate
            // 
            this.btAuthorizate.Location = new System.Drawing.Point(92, 61);
            this.btAuthorizate.Name = "btAuthorizate";
            this.btAuthorizate.Size = new System.Drawing.Size(75, 23);
            this.btAuthorizate.TabIndex = 0;
            this.btAuthorizate.Text = "Authorizate";
            this.btAuthorizate.UseVisualStyleBackColor = true;
            // 
            // tbEnterName
            // 
            this.tbEnterName.Location = new System.Drawing.Point(92, 23);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(143, 20);
            this.tbEnterName.TabIndex = 1;
            // 
            // lbEnterName
            // 
            this.lbEnterName.AutoSize = true;
            this.lbEnterName.Location = new System.Drawing.Point(25, 26);
            this.lbEnterName.Name = "lbEnterName";
            this.lbEnterName.Size = new System.Drawing.Size(61, 13);
            this.lbEnterName.TabIndex = 2;
            this.lbEnterName.Text = "Enter name";
            // 
            // AuthorizationForm
            // 
            this.ClientSize = new System.Drawing.Size(267, 106);
            this.Controls.Add(this.lbEnterName);
            this.Controls.Add(this.tbEnterName);
            this.Controls.Add(this.btAuthorizate);
            this.Name = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
