using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RawMessenger.Networking
{
    class Constants
    {
        public const int MAX_CLIENTS = 10;
        public const int PORT = 5050;
        public const int BUFFER_SIZE = 1024;
    }


    class StateObject
    {
        public Socket workSocket;
        public byte[] buffer = new byte[Constants.BUFFER_SIZE];


    }
    class Server
    {
        private Socket mainSocket;
        private int count;

        public Server() { }

        public void StartListening()
        {
            Console.Write("Starting server on localhost:5050...\n");
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5050);

            mainSocket = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                mainSocket.Bind(localEndPoint);
                mainSocket.Listen(Constants.PORT);

                Console.Write("Listening...");
                mainSocket.BeginAccept(new AsyncCallback(OnClientIncomingConnection), null);
                Console.Write("Incoming connection from " + localEndPoint);
            }
            catch(SocketException e)
            {
                Console.Write("Error: " + e.ToString());
            }

        }


        public void OnClientIncomingConnection(IAsyncResult ar)
        {
            Console.Write("Connected.");
            //if max clients for now, reject connection
            if (count > Constants.MAX_CLIENTS)
            {
                mainSocket.EndAccept(ar);
                return;
            }

            
            StateObject so = new StateObject();

            //give reference to new socket, to workSocket of new connection
            so.workSocket = mainSocket.EndAccept(ar);
            ++count;

            so.workSocket.BeginReceive(so.buffer, 0, Constants.BUFFER_SIZE, 0, new AsyncCallback(OnIncomingData), so);

            mainSocket.BeginAccept(new AsyncCallback(OnClientIncomingConnection), null);
            
        }

        public void OnIncomingData(IAsyncResult ar)
        {
            StateObject so = (StateObject) ar.AsyncState;

            int bytesRead = so.workSocket.EndReceive(ar);
            string content;

            if(bytesRead > 0 && bytesRead < Constants.BUFFER_SIZE)
            {
                content = Encoding.ASCII.GetString(so.buffer, 0, bytesRead);
                Console.Write(content);
            } 
        }
    }
}
