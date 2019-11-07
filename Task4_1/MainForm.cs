using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using S22.Imap;

namespace Bai3
{
    public partial class MainForm : Form
    {
        static MainForm f;
        static List<Email_Receive> list_email = new List<Email_Receive>();
        //static Email_Receive email = new Email_Receive();
        static List<ListViewItem> list_item = new List<ListViewItem>();
        OpenFileDialog Ofd;
        Account account = new Account();
        public MainForm(Account account_mail)
        {
            InitializeComponent();
            account.Email = account_mail.Email;
            account.Password = account_mail.Password;
            this.CenterToScreen();
            f = this;
        }

        private bool Check_String_Hex(string hex)
        {
            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[i] > 'f' || hex[i] < '0')
                {
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListView_Inbox.FullRowSelect = true;
            Start_receive_Data();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sending_Mail form = new Sending_Mail(account);
            var Result = form.ShowDialog();                    
        }

        private void Start_receive_Data()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, account.Email, account.Password, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        MessageBox.Show("Server not support IMAP IDLE!", "Notification!");
                    }
                    else
                    {
                        client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                        while (true) ;

                    }
                }
            }
            );
        }

        static MailMessage message;

        static void OnNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New Message Received!", "Notification!");
            
            message = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                Email_Receive email = new Email_Receive();
                email.Email = message.From.ToString();
                email.Subject = message.Subject.ToString();
                email.Message = message.Body;
                email.Datetime = (DateTime)message.Date();
                email.Mailmessage = message;
                list_email.Add(email);
            });
            f.ListView_Inbox.Items.Clear();
            ListViewItem item = new ListViewItem();
            item.Text = list_email[list_email.Count - 1].Email;
            item.SubItems.Add(list_email[list_email.Count - 1].Message);
            item.SubItems.Add(list_email[list_email.Count - 1].Datetime.ToString());
            list_item.Add(item);
            for (int i = list_item.Count - 1 ;i >= 0;i--)
            {
                try
                {
                    f.ListView_Inbox.Items.Add(list_item[i]);
                }
                catch (Exception)
                {

                }
            }         
        }

        private void ListView_Inbox_MouseClick(object sender, MouseEventArgs e)
        {
            Email_Receive email1 = new Email_Receive();
            string email = ListView_Inbox.SelectedItems[0].SubItems[0].Text;
            string datetime = ListView_Inbox.SelectedItems[0].SubItems[2].Text;
            int index = -1;
            for(int i = 0;i < list_email.Count;i++)
            {
                if(list_email[i].Email == email && datetime == list_email[i].Datetime.ToString())
                {
                    index = i;
                    break;
                }
            }
            Receive_Mail form_receive_mail = new Receive_Mail(account, list_email[index].Mailmessage);
            form_receive_mail.Show();
            // MessageBox.Show("Index : " + index.ToString() + " Mail  : " + email + " DateTime  : " + datetime.ToString() + " DateTime of list_email0 : " + list_email[0].Datetime.ToString() + " DateTime of list_email1 : " + list_email[1].Datetime.ToString());
            //MessageBox.Show("DateTime of list_email0 : " + list_email[0].Datetime.ToString() + " DateTime of list_email1 : " + list_email[1].Datetime.ToString() + "DateTime of list_email3 : " + list_email[2].Datetime.ToString() + "DateTime of list_email3 : " + list_email[3].Datetime.ToString());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
