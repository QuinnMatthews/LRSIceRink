using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;
using Azure;
using Azure.Communication.Email;
using Azure.Communication.Email.Models;

namespace LRSIceRink.Services {
    public class EmailSender : IEmailSender {
        // Our private configuration variables
        private string connectionString;

        // Get our parameterized configuration
        public EmailSender(string conString)
        {
            connectionString = conString;
        }

        // Use our configuration to send the email by using SmtpClient
        public async Task SendEmailAsync(string email, string subject, string htmlMessage) {
            EmailClient emailClient = new EmailClient(connectionString);
            EmailContent emailContent = new EmailContent(subject);
            emailContent.Html = htmlMessage;
            List<EmailAddress> emailAddresses = new List<EmailAddress> { new(email)};
            EmailRecipients emailRecipients = new EmailRecipients(emailAddresses);
            EmailMessage emailMessage = new EmailMessage("operations@lrsicerink.com", emailContent, emailRecipients);
            SendEmailResult emailResult = await emailClient.SendAsync(emailMessage, CancellationToken.None);
        }
    }
}
