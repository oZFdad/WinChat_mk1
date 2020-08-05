namespace Client
{
    partial class ChatClient
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.btCreateChat = new System.Windows.Forms.Button();
            this.btJoinChat = new System.Windows.Forms.Button();
            this.btQuitChat = new System.Windows.Forms.Button();
            this.btSendMess = new System.Windows.Forms.Button();
            this.tbChatMessage = new System.Windows.Forms.TextBox();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.btInvite = new System.Windows.Forms.Button();
            this.btRegisteration = new System.Windows.Forms.Button();
            this.btAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(633, 39);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(117, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCreateChat
            // 
            this.btCreateChat.Location = new System.Drawing.Point(633, 83);
            this.btCreateChat.Name = "btCreateChat";
            this.btCreateChat.Size = new System.Drawing.Size(117, 23);
            this.btCreateChat.TabIndex = 1;
            this.btCreateChat.Text = "Create Chat";
            this.btCreateChat.UseVisualStyleBackColor = true;
            this.btCreateChat.Click += new System.EventHandler(this.btCreateChat_Click);
            // 
            // btJoinChat
            // 
            this.btJoinChat.Location = new System.Drawing.Point(633, 124);
            this.btJoinChat.Name = "btJoinChat";
            this.btJoinChat.Size = new System.Drawing.Size(117, 23);
            this.btJoinChat.TabIndex = 2;
            this.btJoinChat.Text = "Join Chat";
            this.btJoinChat.UseVisualStyleBackColor = true;
            this.btJoinChat.Click += new System.EventHandler(this.btJoinChat_Click);
            // 
            // btQuitChat
            // 
            this.btQuitChat.Location = new System.Drawing.Point(633, 166);
            this.btQuitChat.Name = "btQuitChat";
            this.btQuitChat.Size = new System.Drawing.Size(117, 23);
            this.btQuitChat.TabIndex = 3;
            this.btQuitChat.Text = "Quit chat";
            this.btQuitChat.UseVisualStyleBackColor = true;
            this.btQuitChat.Click += new System.EventHandler(this.btQuitChat_Click);
            // 
            // btSendMess
            // 
            this.btSendMess.Location = new System.Drawing.Point(633, 395);
            this.btSendMess.Name = "btSendMess";
            this.btSendMess.Size = new System.Drawing.Size(117, 23);
            this.btSendMess.TabIndex = 4;
            this.btSendMess.Text = "Send Message";
            this.btSendMess.UseVisualStyleBackColor = true;
            this.btSendMess.Click += new System.EventHandler(this.btSendMess_Click);
            // 
            // tbChatMessage
            // 
            this.tbChatMessage.Location = new System.Drawing.Point(12, 12);
            this.tbChatMessage.Name = "tbChatMessage";
            this.tbChatMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChatMessage.Size = new System.Drawing.Size(519, 20);
            this.tbChatMessage.TabIndex = 5;
            this.tbChatMessage.TabStop = false;
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(12, 398);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(530, 20);
            this.tbSendMessage.TabIndex = 6;
            // 
            // btInvite
            // 
            this.btInvite.Location = new System.Drawing.Point(633, 244);
            this.btInvite.Name = "btInvite";
            this.btInvite.Size = new System.Drawing.Size(117, 23);
            this.btInvite.TabIndex = 7;
            this.btInvite.Text = "Invite friend";
            this.btInvite.UseVisualStyleBackColor = true;
            // 
            // btRegisteration
            // 
            this.btRegisteration.Location = new System.Drawing.Point(633, 347);
            this.btRegisteration.Name = "btRegisteration";
            this.btRegisteration.Size = new System.Drawing.Size(117, 23);
            this.btRegisteration.TabIndex = 8;
            this.btRegisteration.Text = "Registeration";
            this.btRegisteration.UseVisualStyleBackColor = true;
            // 
            // btAuthorization
            // 
            this.btAuthorization.Location = new System.Drawing.Point(633, 298);
            this.btAuthorization.Name = "btAuthorization";
            this.btAuthorization.Size = new System.Drawing.Size(117, 23);
            this.btAuthorization.TabIndex = 9;
            this.btAuthorization.Text = "Authorization";
            this.btAuthorization.UseVisualStyleBackColor = true;
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btAuthorization);
            this.Controls.Add(this.btRegisteration);
            this.Controls.Add(this.btInvite);
            this.Controls.Add(this.tbSendMessage);
            this.Controls.Add(this.tbChatMessage);
            this.Controls.Add(this.btSendMess);
            this.Controls.Add(this.btQuitChat);
            this.Controls.Add(this.btJoinChat);
            this.Controls.Add(this.btCreateChat);
            this.Controls.Add(this.btConnect);
            this.Name = "ChatClient";
            this.Text = "ChatClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCreateChat;
        private System.Windows.Forms.Button btJoinChat;
        private System.Windows.Forms.Button btSendMess;
        private System.Windows.Forms.Button btQuitChat;
        private System.Windows.Forms.TextBox tbChatMessage;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Button btInvite;
        private System.Windows.Forms.Button btRegisteration;
        private System.Windows.Forms.Button btAuthorization;
    }
}

