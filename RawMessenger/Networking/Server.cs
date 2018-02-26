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
        public IPAddress ip;
        public int port;


    }
    class Server
    {
        private Logging.Console logger;
        private Socket mainSocket;
        private int count;

        public Server(MessengerWindow window) {
            logger = new Logging.Console(window);

        }

        
        public void StartListening(int port)
        {

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5050);
            StateObject so = new StateObject();
            so.ip = ipAddress;
            so.port = port;

            logger.ServerLog("SERVER: Starting server on " + ipAddress + ":" + Constants.PORT + " ...\n");



            mainSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                mainSocket.Bind(localEndPoint);
                mainSocket.Listen(Constants.PORT);

                mainSocket.BeginAccept(new AsyncCallback(OnClientIncomingConnection), so);
                logger.ServerLog("SERVER: Incoming connection from " + ipAddress + ":" + Constants.PORT + "\n");
            }
            catch(SocketException e)
            {
                logger.ServerLog("Error: " + e.ToString());
            }

        }


        public void OnClientIncomingConnection(IAsyncResult ar)
        {
            
            
            //if max clients for now, reject connection
            if (count > Constants.MAX_CLIENTS)
            {
                mainSocket.EndAccept(ar);
                return;
            }




            //give reference to new socket, to workSocket of new connection
            StateObject so = (StateObject)ar.AsyncState;
            so.workSocket = mainSocket.EndAccept(ar);

            logger.ServerLog("Connection from " + so.ip + ":" + so.port + " successful.\n");
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
                logger.MessageLog(so.ip + ":" + so.port, content + "\n");
            } 
        }
    }
}
