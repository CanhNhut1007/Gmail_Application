using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;
using System.Net.Mail;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace Bai3
{
    public partial class Receive_Mail: Form
    {
        static List<Email_Receive> list_email = new List<Email_Receive>();
        static Email_Receive email = new Email_Receive();
        Account account = new Account();
        Email_Receive email_receive = new Email_Receive();
        static MailMessage message;
        public Receive_Mail(Account account_mail,MailMessage mailmessage)
        {
            InitializeComponent();
            this.CenterToScreen();
            account.Email = account_mail.Email;
            account.Password = account_mail.Password;
            this.CenterToScreen();
            email_receive = email;
            message = mailmessage;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtb_Email.Text = message.From.ToString();
            txtb_Subject.Text = message.Subject.ToString();

            rtb_Message.Text = "(" + message.Date().ToString() + ")" + " : ";
            rtb_Message.Text += message.Body;
            List<string> list_name = new List<string>();
            
            for(int k = 0;k < 3;k++)
            {
                list_name.Add("Not file attach");
            }
            int i = 0;
            foreach (var attachment in message.Attachments)
            {
                if (i >= 3)
                    break;
                list_name[i] = attachment.Name;
                i++;     
            }
            int j = 0;
            Label_File_attach1.Text = list_name[j];
            j++;
            Label_File_attach2.Text = list_name[j];
            j++;
            Label_File_attach3.Text = list_name[j];
            j++;
        }
        private void btn_Receive_Click(object sender, EventArgs e)
        {

        }

        //private void Start_receive_Data()
        //{
        //    Task.Run(() =>
        //    {
        //        using (ImapClient client = new ImapClient("imap.gmail.com", 993, account.Email,account.Password, AuthMethod.Login, true))
        //        {
        //            if (client.Supports("IDLE") == false)
        //            {
        //                MessageBox.Show("Server not support IMAP IDLE!", "Notification!");
        //            }
        //            else
        //            {
        //                client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
        //                while (true) ;

        //            }
        //        }
        //    }
        //    );
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Label_File_attach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Label label = sender as Label;
            if (label.Text != "Not file attach")
            {
                foreach (var attachment in message.Attachments)
                {
                    if(attachment.Name == label.Text)
                    {
                       
                        SaveFileDialog Sfd = new SaveFileDialog();
                        Sfd.FileName = attachment.Name;
                        Sfd.Filter = "All files (*.*)|*.*";
                        DialogResult result = Sfd.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            using (var fileStream = File.Create(Sfd.FileName))
                            {
                                attachment.ContentStream.Seek(0, SeekOrigin.Begin);
                                attachment.ContentStream.CopyTo(fileStream);
                            }
                        }
                        
                    }                  
                }
            }


        }
    }
}

