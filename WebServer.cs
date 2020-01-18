using System;

namespace ServerManagementFactory
{
    public class WebServer : IServer
    {
        public void Resolve()
        {
            Console.WriteLine("Performing some complex Web Server Resolution Algorithm.");
            Console.WriteLine("Web Server has been fixed!");
        }
    }
}