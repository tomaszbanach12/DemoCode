using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class EmailMessageBuffer
    {
        public List<EmailMessage> Emails { get; set; } = new List<EmailMessage>();

        public void SendAll()
        {
            foreach (var email in Emails)
	        {
                Console.WriteLine(email.MessageBody);
                // Send Email
	        }
        }

        public void AddMessage(EmailMessage emailMessage)
        {
            Emails.Add(emailMessage);
        }
    }
}
