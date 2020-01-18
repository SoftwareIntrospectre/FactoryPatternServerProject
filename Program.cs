using System;

namespace ServerManagementFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which server do you want to resolve?");
            string userServerChoice = Console.ReadLine();
            string serverResult = userServerChoice;

            IServer server = ServerManagementFactory.GetServer(serverResult);
            server.Resolve();
        }
    }
}
