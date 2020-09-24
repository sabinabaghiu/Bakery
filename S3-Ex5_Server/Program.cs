using System;

namespace S3_Ex5_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatServer chatServer = new ChatServer();
            chatServer.Start();
        }
    }
}