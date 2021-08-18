﻿using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Security;

namespace Seq.App.EmailPlus
{
    class SmtpOptions
    {
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; } = 25;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RequiresAuthentication { get; set; }
        public SecureSocketOptions SocketOptions { get; set; }
    }
}
