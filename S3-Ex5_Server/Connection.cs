using System.Collections.Generic;

namespace S3_Ex5_Server
{
    public class Connection
    {
        private List<ServerHandler> connection = new List<ServerHandler>();

        public void BroadcastMessage(string message)
        {
            connection.ForEach(handler => handler.SendMessage(message));
        }

        public void AddHandler(ServerHandler communicationThreadHandler)
        {
            connection.Add(communicationThreadHandler);
        }

        public void RemoveHandler(ServerHandler communicationThreadHandler)
        {
            connection.Remove(communicationThreadHandler);
        }
    }
}