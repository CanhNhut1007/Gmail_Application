using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static Bai3.Account;

namespace Bai3
{


    public partial class Login : Form
    {
        //public Bai3.Account account;
        //public delegate void delPassData(Bai3.Account account);
        private Account account = new Account();


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.TextEdit_Account.Text != "" && this.TextEdit_Password.Text != "")
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = false;
                NetworkCredential basicCredential = new NetworkCredential(this.TextEdit_Account.Text, this.TextEdit_Password.Text);
                smtpClient.UseDefaultCredentials = true;

                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;

                MailMessage message = new MailMessage();
                MailAddress fromAddress = new MailAddress(this.TextEdit_Account.Text);

                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Credentials = basicCredential;

                message.From = fromAddress;
                message.Subject = "Authentication";
                //Set IsBodyHtml to true means you can send HTML email.
                message.IsBodyHtml = true;
                message.Body = "<h1>Check account</h1>";
                message.To.Add("mailer-daemon@googlemail.com");

                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Login success!", "Notification!");
                    account.Email = this.TextEdit_Account.Text;
                    account.Password = this.TextEdit_Password.Text;
                    this.TextEdit_Account.Text = "";
                    this.TextEdit_Password.Text = "";
                    this.Hide();
                    MainForm form = new MainForm(account);
                    var Result = form.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                    ////Receive_Mail form = new Receive_Mail(account);
                    //var Result = form.ShowDialog();
                    //if (Result == DialogResult.Cancel)
                    //{
                    //    this.Show();
                    //}
                }
                catch (Exception ex)
                {
                    //Error, could not send the message
                    MessageBox.Show("Infomation Login Invaild!", "Notification!");
                }
            }
            else
            {
                MessageBox.Show("Infomation Login Invaild!", "Notification!");
            }

        }

     

       

      
    }
}

