using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex3_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server...");
            
            IPAddress ip = IPAddress.Parse("192.168.8.107");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            
            Console.WriteLine("Server started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                
                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();
                
                //read
                while (true)
                {
                    byte[] dataFromClient = new byte[1024];
                    int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                    string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                    Console.WriteLine(s);

                    //respond
                    byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                    stream.Write(dataToClient, 0, dataToClient.Length);

                    if (s == "exit")
                    {
                        break;
                    }
                }

                //close connection
                client.Close();
            }
        }
    }
}