namespace ServerManagementFactory
{
    //Pump out different types of server objects
    public class ServerManagementFactory
    {
        public static IServer GetServer(string serverType)
        {
            switch(serverType)
            {
                case "mail":
                    return new MailServer();

                case "sftp":
                    return new SftpServer();

                case "web":
                    return new WebServer();

                default:
                    throw new System.Exception("invalid server type");            
            }
        }
    }
}