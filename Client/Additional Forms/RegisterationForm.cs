using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Additional_Forms
{
    class RegisterationForm : Form
    {
        private TextBox textBox1;
        private Button btRegistration;
        private Label lbEnterName;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbEnterName = new System.Windows.Forms.Label();
            this.btRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbEnterName
            // 
            this.lbEnterName.AutoSize = true;
            this.lbEnterName.Location = new System.Drawing.Point(25, 27);
            this.lbEnterName.Name = "lbEnterName";
            this.lbEnterName.Size = new System.Drawing.Size(61, 13);
            this.lbEnterName.TabIndex = 1;
            this.lbEnterName.Text = "Enter name";
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(110, 59);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(75, 23);
            this.btRegistration.TabIndex = 2;
            this.btRegistration.Text = "Registration";
            this.btRegistration.UseVisualStyleBackColor = true;
            // 
            // RegisterationForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 97);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.lbEnterName);
            this.Controls.Add(this.textBox1);
            this.Name = "RegisterationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
