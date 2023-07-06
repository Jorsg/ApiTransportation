using System;

namespace EmailServices
{
    public class EmailConfiguration
    {
        /// <summary>
        /// SmtpServer
        /// </summary>
       public string SmtpServer { get; set; }

        /// <summary>
        /// SmtpPort
        /// </summary>
        public int SmtpPort { get; set; }

        /// <summary>
        /// SmtpUsername
        /// </summary>
        public string SmtpUsername { get; set; }

        /// <summary>
        /// SmtpPassword
        /// </summary>
        public string SmtpPassword { get; set; }

        /// <summary>
        /// EnableSsl
        /// </summary>
        public bool EnableSsl { get; set; }

        public string From { get; set; }
        public int MaxFileLengthBytes { get; set; }
    }
}
