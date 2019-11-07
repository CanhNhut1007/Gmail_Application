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
using System.Net;
using static Bai3.Account;

namespace Bai3
{
    public partial class Sending_Mail : Form
    {
        private Account account = new Account();
        FileStream fs = null;
        StreamReader sr = null;
        public Sending_Mail(Account account_login)
        {
            InitializeComponent();
            account = account_login;
            this.CenterToScreen();
        }

        OpenFileDialog Ofd;
        private void btn_Attach_Click(object sender, EventArgs e)
        {
            Ofd = new OpenFileDialog();

            DialogResult result = Ofd.ShowDialog();

            try
            {
                if(Ofd.FileName != "")
                {
                    fs = new FileStream(Ofd.FileName, FileMode.OpenOrCreate);
                }          
            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (result != DialogResult.Cancel)
                {
                    this.txt_link.Text = Ofd.FileName;
                    fs.Close();
                }
            }
            

        }

        private List<Info_Email> Take_List_Email(DataGridView datagridview)
        {
            List<Info_Email> list_email = new List<Info_Email>();
            int n = datagridview.Rows.Add();
            for (int i = 0; i < n; i++)
            {
                Info_Email info_email = new Info_Email();
                info_email.Email = datagridview.Rows[i].Cells[0].Value.ToString();
                info_email.Name = datagridview.Rows[i].Cells[1].Value.ToString();
                info_email.Mssv = datagridview.Rows[i].Cells[2].Value.ToString();
                list_email.Add(info_email);
            }

            return list_email;
        }

        private List<Info_Email> Take_List_Email_BCC(DataGridView datagridview)
        {
            List<Info_Email> list_email = new List<Info_Email>();
            int n = datagridview.Rows.Add();
            for (int i = 0; i < n; i++)
            {
                Info_Email info_email = new Info_Email();
                info_email.Email = datagridview.Rows[i].Cells[0].Value.ToString();
                list_email.Add(info_email);
            }

            return list_email;
        }

        private List<Info_Email> Take_List_Email_CC(DataGridView datagridview)
        {
            List<Info_Email> list_email = new List<Info_Email>();
            int n = datagridview.Rows.Add();
            for (int i = 0; i < n; i++)
            {
                Info_Email info_email = new Info_Email();
                info_email.Email = datagridview.Rows[i].Cells[0].Value.ToString();
                list_email.Add(info_email);
            }

            return list_email;
        }

        private bool Check(ref List<Info_Email> list_email, string email)
        {
            for (int i = 0; i < list_email.Count; i++)
            {
                if (list_email[i].Email == email)
                {
                    list_email.Remove(list_email[i]);
                    return true;
                }
            }
            return false;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mãng ký tự
            Array.Reverse(arr); // đảo ngược mãng
            return new string(arr); // trả về chuỗi mới sau khi đảo mãng
        }

        private void Send_Mail(List<Info_Email> list_info_email, ref List<Info_Email> list_info_email_BCC, ref List<Info_Email> list_info_email_CC)
        {
            int count = 0;
            for (int i = 0; i < list_info_email.Count; i++)
            {

                var message = new MailMessage(account.Email, list_info_email[i].Email);
                message.Subject = txtBox_Subject.Text;
                string body = rtb_send_gmail.Text;
                body = body.Replace("<Tên người nhận>", list_info_email[i].Name);
                body = body.Replace("md5(<MSSV>)", list_info_email[i].Mssv);
                message.Body = body;
                System.Net.Mail.Attachment att = null;
                if (this.txt_link.Text != "")
                {
                    att = new Attachment(Ofd.FileName);

                    message.Attachments.Add(att);
                }

                message.To.Add(new MailAddress(list_info_email[i].Email));

                for (int j = 0; j < list_info_email_CC.Count; j++)
                {
                    message.CC.Add(new MailAddress(list_info_email_CC[j].Email));
                }

                for (int j = 0; j < list_info_email_BCC.Count; j++)
                {
                    message.Bcc.Add(new MailAddress(list_info_email_BCC[j].Email));
                }

                using (SmtpClient smtpclient = new SmtpClient(this.txtBox_Gmail.Text, int.Parse(this.txtBox_Gmail_Port.Text)))
                {
                    smtpclient.UseDefaultCredentials = false;
                    NetworkCredential basicCredential = new NetworkCredential(account.Email, account.Password);
                    smtpclient.UseDefaultCredentials = true;
                    smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpclient.EnableSsl = true;
                    smtpclient.Credentials = basicCredential;
                    try
                    {

                        smtpclient.Send(message);
                        count++;

                    }
                    catch (Exception)
                    {
                        //Error, could not send the message
                        MessageBox.Show("Error Network!", "Notification!");
                    }
                }
                if (att != null)
                    att.Dispose();
            }


        }



        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (Radio_button_Gmail.Checked == true)
            {

                List<Info_Email> list_info_email = new List<Info_Email>();
                List<Info_Email> list_info_email_BCC = new List<Info_Email>();
                List<Info_Email> list_info_email_CC = new List<Info_Email>();


                list_info_email = Take_List_Email(DataGridview_Email);
                list_info_email_BCC = Take_List_Email_BCC(DataGridView_BCC);
                list_info_email_CC = Take_List_Email_CC(DataGridView_CC);

                Send_Mail(list_info_email, ref list_info_email_BCC, ref list_info_email_CC);



                MessageBox.Show("Send Mail success!", "Notification!");
                this.DataGridview_Email.Rows.Clear();
                this.DataGridView_BCC.Rows.Clear();
                this.DataGridView_CC.Rows.Clear();
                this.txtBox_Subject.Text = "";
                this.rtb_send_gmail.Text = "";
                this.txt_link.Text = "";
                this.Close();

            }


        }
        private void Sending_Mail_Load(object sender, EventArgs e)
        {

        }
    }
}

