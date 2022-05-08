using Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email,ApplicationUser user) 
        {
            var Client = new SmtpClient("smtp.gmail.com",587);
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("mailservice7539@gmail.com", "MailAgent2499");
            Client.Send("mailservice7539@gmail.com", user.Email,email.Title,email.Body);
        }
    }
}
