using System;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex3_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client...");
            
            TcpClient client = new TcpClient("192.168.8.107", 5000);

            NetworkStream stream = client.GetStream();

            Console.Out.WriteLine("Write text:");

            string text = "";
            while (text != "exit")
            {
                text = Console.ReadLine();

                byte[] dataToServer = Encoding.ASCII.GetBytes("Hello from client");
                stream.Write(dataToServer, 0, dataToServer.Length);

                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }

            stream.Close();
            client.Close();
        }
    }
}