using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smptServer;
        private int smtpPort;
        private string fromEmailAddress;

        public EmailSender(string smptServer, int smtpPort, string fromEmailAddress)
        {
            this.smptServer = smptServer;
            this.smtpPort = smtpPort;
            this.fromEmailAddress = fromEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true,
            };

            message.To.Add(new MailAddress(email));

            using (var client = new SmtpClient(smptServer, smtpPort))
            {
                client.Send(message);
            }

            return Task.CompletedTask;

        }
    }
}
