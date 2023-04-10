using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sent_Mail
{
    public partial class Form1 : Form
    {
        Attachment attach = null;
        public Form1()
        {
            InitializeComponent();
        }


        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            
            if(attach != null)
            {
                mess.Attachments.Add(attach);
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true; ;

            client.Credentials = new NetworkCredential(Signin.Text, Pass.Text);

            client.Send(mess);
        }


        private void Sent_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(File.Text);
                    attach = new Attachment(File.Text);
                }
                catch { }

                StreamReader sr = new StreamReader(To.Text);

                string email;

                while ((email = sr.ReadLine()) != null)
                {

                    GuiMail(Signin.Text, email, Subject.Text, Message.Text);

                }
                MessageBox.Show("Email đã được gửi thành công");
            }
            );
            thread.Start();
          
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); 
            if ( dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                File.Text = dialog.FileName;
            }
        }

        private void dsmail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                To.Text = dialog.FileName;
            }
        }
    }
}
