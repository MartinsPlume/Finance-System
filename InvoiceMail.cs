using System;
using System.Net.Mail;

namespace FinanceSystem
{
    public class InvoiceMail
    {
        private readonly MailMessage _mail;
        private readonly SmtpClient _smtpServer;
        public InvoiceMail(string to, int orderId, string orderPerson, int postalCode )
        {
            _mail = new MailMessage
            {
                From = new MailAddress("kursadarbsprogrammesana@inbox.lv"),
                To = { to },
                Subject = $"Invoice number {orderId}",
                Body =
                    $@"Dear {orderPerson}!{Environment.NewLine}Your order will be delivered to postal code {postalCode}!"
            };
            _smtpServer = new SmtpClient("mail.inbox.lv");
        }

        public void SendInvoiceMail()
        {
            _smtpServer.Port = 587;
            _smtpServer.Credentials = new System.Net.NetworkCredential($"kursadarbsprogrammesana@inbox.lv", $"WHM757Tgra");
            _smtpServer.EnableSsl = true;
            _smtpServer.Send(_mail);
        }
    }
}