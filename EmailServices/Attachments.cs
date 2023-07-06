using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailServices
{
    public class Attachments
    {
        public string fileName { get; set; }
        public string fileBase64 { get; set; }

    }
}
