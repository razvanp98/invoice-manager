namespace InvoiceManager
{
    partial class SendMailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginEmail_input = new System.Windows.Forms.TextBox();
            this.loginPwd_input = new System.Windows.Forms.TextBox();
            this.toEmail_input = new System.Windows.Forms.TextBox();
            this.subjectEmail_input = new System.Windows.Forms.TextBox();
            this.composeMailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginEmail_input
            // 
            this.loginEmail_input.Location = new System.Drawing.Point(12, 12);
            this.loginEmail_input.Name = "loginEmail_input";
            this.loginEmail_input.Size = new System.Drawing.Size(360, 20);
            this.loginEmail_input.TabIndex = 0;
            this.loginEmail_input.Text = "Login email";
            // 
            // loginPwd_input
            // 
            this.loginPwd_input.Location = new System.Drawing.Point(12, 50);
            this.loginPwd_input.Name = "loginPwd_input";
            this.loginPwd_input.PasswordChar = '*';
            this.loginPwd_input.Size = new System.Drawing.Size(360, 20);
            this.loginPwd_input.TabIndex = 1;
            this.loginPwd_input.Text = "Login password";
            // 
            // toEmail_input
            // 
            this.toEmail_input.Location = new System.Drawing.Point(12, 90);
            this.toEmail_input.Name = "toEmail_input";
            this.toEmail_input.Size = new System.Drawing.Size(360, 20);
            this.toEmail_input.TabIndex = 2;
            this.toEmail_input.Text = "To";
            // 
            // subjectEmail_input
            // 
            this.subjectEmail_input.Location = new System.Drawing.Point(12, 132);
            this.subjectEmail_input.Name = "subjectEmail_input";
            this.subjectEmail_input.Size = new System.Drawing.Size(360, 20);
            this.subjectEmail_input.TabIndex = 3;
            this.subjectEmail_input.Text = "Subject";
            // 
            // composeMailBtn
            // 
            this.composeMailBtn.Location = new System.Drawing.Point(297, 226);
            this.composeMailBtn.Name = "composeMailBtn";
            this.composeMailBtn.Size = new System.Drawing.Size(75, 23);
            this.composeMailBtn.TabIndex = 4;
            this.composeMailBtn.Text = "Send";
            this.composeMailBtn.UseVisualStyleBackColor = true;
            this.composeMailBtn.Click += new System.EventHandler(this.composeMailBtn_Click);
            // 
            // SendMailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.composeMailBtn);
            this.Controls.Add(this.subjectEmail_input);
            this.Controls.Add(this.toEmail_input);
            this.Controls.Add(this.loginPwd_input);
            this.Controls.Add(this.loginEmail_input);
            this.Name = "SendMailView";
            this.Text = "Send Mail Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginEmail_input;
        private System.Windows.Forms.TextBox loginPwd_input;
        private System.Windows.Forms.TextBox toEmail_input;
        private System.Windows.Forms.TextBox subjectEmail_input;
        private System.Windows.Forms.Button composeMailBtn;
    }
}