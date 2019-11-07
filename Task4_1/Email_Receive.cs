using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Bai3
{
    public class Email_Receive
    {
        private string email;
        private string subject;
        private DateTime datetime;
        private string message;
        private MailMessage mailmessage;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }


        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public DateTime Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }

        public MailMessage Mailmessage
        {
            get { return mailmessage; }
            set { mailmessage = value; }
        }
    }
}
