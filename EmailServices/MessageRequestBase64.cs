using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailServices
{
    public class MessageRequestBase64
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Attachments[] Attachments { get; set; }

    }
}
