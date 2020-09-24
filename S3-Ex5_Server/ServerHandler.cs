using System;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex5_Server
{
    public class ServerHandler
    {
        private NetworkStream stream;
        private Connection connection;

        public ServerHandler(NetworkStream stream, Connection connection)
        {
            this.stream = stream;
            this.connection = connection;
        }

        public void Run()
        {
            Console.Out.WriteLine("Thread started...");

            while (true)
            {
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);
                
                if (s == "exit")
                {
                    connection.RemoveHandler(this);
                    break;
                }
                
                connection.BroadcastMessage(s);
            }
        }

        public void SendMessage(string message)
        {
            byte[] dataToClient = Encoding.ASCII.GetBytes(message);
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}