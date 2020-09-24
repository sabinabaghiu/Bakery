using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex5_Client
{
    public class ClientReciever
    {

        private Stream stream;
        private Client client;

        public ClientReciever(NetworkStream stream, Client client)
        {
            this.stream = stream;
            this.client = client;
        }

        public void Run()
        {
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                client.WriteOutputMessage(response);
            }
        }

        public void SendMessage(String message)
        {
            byte[] dataToServer = Encoding.ASCII.GetBytes(message);
            stream.Write(dataToServer, 0, dataToServer.Length);
        }
    }
}