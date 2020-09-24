using System;
using System.Net.Sockets;
using System.Threading;

namespace S3_Ex5_Client
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("Starting client...");
            
            TcpClient client = new TcpClient("192.168.8.107", 5000);

            NetworkStream stream = client.GetStream();
            
            ClientReciever clientReciever = new ClientReciever(stream, this);
            
            Thread thread = new Thread(clientReciever.Run);
            thread.Start();

            while (true)
            {
                Console.Out.WriteLine("Write text: ");
                string text = Console.ReadLine();
                clientReciever.SendMessage(text);

                if (text == "exit")
                {
                    break;
                }
            }
        }

        public void WriteOutputMessage(string response)
        {
            Console.Out.WriteLine("Received: " + response);
        }
    }
}