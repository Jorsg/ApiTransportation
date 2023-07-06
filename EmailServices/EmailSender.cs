using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmailServices
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.Add(new MailboxAddress(message.To));
            emailMessage.Subject = message.Subject;           

            var bodyBuilder = new BodyBuilder { HtmlBody = message.Content };

            if (message.Attachments != null)
            {
                byte[] fileBytes;
               
                    using (var ms = new MemoryStream())
                    {
                    message.Attachments.CopyTo(ms);
                        fileBytes = ms.ToArray();
                    }
                    bodyBuilder.Attachments.Add(message.Attachments.FileName, fileBytes, ContentType.Parse(message.Attachments.ContentType));
                
            }
            emailMessage.Body = bodyBuilder.ToMessageBody();

            return emailMessage;
        }

        private void Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailConfig.SmtpUsername, _emailConfig.SmtpPassword);
                    

                    client.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    throw;
                }
            }
        }


        private MimeMessage CreateEmailMessageBase64(MessageRequestBase64 message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.Add(new MailboxAddress(message.To));
            emailMessage.Subject = message.Subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = message.Content };

            if (message.Attachments != null)
            {
                foreach (var Att in message.Attachments)
                {
                    byte[] fileBytes = Convert.FromBase64String(Att.fileBase64);
                    bodyBuilder.Attachments.Add(Att.fileName, fileBytes);
                }            

            }
            emailMessage.Body = bodyBuilder.ToMessageBody();

            return emailMessage;
        }

        void IEmailSender.SendEmailBase64(MessageRequestBase64 message)
        {
            if (String.IsNullOrEmpty(message.To))
            {
                throw new Exception("Email destination is required");
            }

            if (String.IsNullOrEmpty(message.Subject))
            {
                throw new Exception("Subject is required");
            }
            if (message.Attachments != null)
            {
                int MAX_FILE_LENGTH_BYTES = _emailConfig.MaxFileLengthBytes;
                foreach (var Att in message.Attachments)
                {
                    byte[] fileBytes = Convert.FromBase64String(Att.fileBase64);
                    var fileLengthBytes = fileBytes.Length;
                    if (fileLengthBytes >= MAX_FILE_LENGTH_BYTES)
                    {
                        throw new Exception("The file size exceeds the maximum size allowed");
                    }
                }
            }


            var emailMessage = CreateEmailMessageBase64(message);
            Send(emailMessage);
        }
    }
}
