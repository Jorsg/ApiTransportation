using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailServices
{
    public class Message
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public IFormFile Attachments { get; set; }

        //public Message(string to, string subject, string content, IFormFile attachments)
        //{
        //    //To = new List<MailboxAddress>();

        //    // To.AddRange(to.Select(x => new MailboxAddress(x)));
        //    To = to;
        //    Subject = subject;
        //    Content = content;
        //    Attachments = attachments;
        //}
    }
}
