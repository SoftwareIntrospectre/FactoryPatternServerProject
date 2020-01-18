using System;

namespace ServerManagementFactory
{
    public class MailServer : IServer
    {
        public void Resolve()
        {
            Console.WriteLine("Performing some complex Mail Server Resolution Algorithm.");
            Console.WriteLine("Mail Server has been fixed!");
        }
    }
}