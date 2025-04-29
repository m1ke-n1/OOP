﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending an email...");
            Disconnect();
        }

        private void Connect() => Console.WriteLine("Connecting to email server...");

        private void Authenticate() => Console.WriteLine("Authenticating...");

        private void Disconnect() => Console.WriteLine("Disconnecting from email server...");
    }
}
