using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S3_Ex5_Server
{
    public class ChatServer
    {
        public void Start()
        {
            Console.WriteLine("Starting server...");

            IPAddress ip = IPAddress.Parse("192.168.8.107");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            Connection connection = new Connection();
            
            Console.WriteLine("Server started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                Console.Out.WriteLine("Client connected");
                
                ServerHandler communicationThreadHandler = new ServerHandler(stream, connection);
                connection.AddHandler(communicationThreadHandler);
                Thread thread = new Thread(communicationThreadHandler.Run);
                thread.Start();
            }
        }
    }
}