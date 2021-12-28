using InvoiceManager.mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class SendMailView : Form
    {
        public SendMailView()
        {
            InitializeComponent();
        }

        private void composeMailBtn_Click(object sender, EventArgs e)
        {
            string emailLogin = loginEmail_input.Text;
            string passwordLogin = loginPwd_input.Text;
            string subject = subjectEmail_input.Text; ;
            string recipient = toEmail_input.Text;

            MailProvider mailProvider = MailProvider.getInstance();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = mailProvider.smtpPort,
                Credentials = new NetworkCredential(emailLogin, passwordLogin),
                EnableSsl = true,
            };

            var mailMsg = new MailMessage
            {
                From = new MailAddress(emailLogin),
                Subject = subject,
                Body = mailProvider.body,
                IsBodyHtml = true,
            };

            mailMsg.To.Add(recipient);
            try
            {
                smtpClient.Send(mailMsg);
            } catch(Exception ex)
            {
                MessageBox.Show("Could not send email. Caused by: " + ex.Message, "Send failed", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            MessageBox.Show("Message successfully sent. Please check email box", "Send success", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            Close();
        }
    }
}
