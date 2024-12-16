using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal static class SendMail
    {
        public static string tk = "nguyenchi050525@gmail.com";
        public static string mk = "djzq fnqo etzq atqg";

        public static bool sendMailTo(string emailto, string content)
        {
            var fromAddress = new MailAddress(tk, "Admin AVOCADO PHARMACY");
            var toAddress = new MailAddress(emailto, emailto);
            string fromPassword = mk;
            string subject = "Thông báo từ hệ thống Quản lý hiệu thuốc AVOCADO PHARMACY";
            string body = content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
