using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RawMessenger.Networking
{
    class Client
    {
        public static void Send(string ip, string msg)
        {
            Console.Write("Establishing connection to ... " + ip);

            try
            {

                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                TcpClient client = new TcpClient(ipAddress.ToString(), 5050);

                /*
                Byte[] bytes = new Byte[256];
                bytes = Encoding.ASCII.GetBytes(msg);

                NetworkStream stream = client.GetStream();
                stream.Write(bytes, 0, bytes.Length);
                

                stream.Close();
                */
                //client.Close();

            }
            catch (SocketException e)
            {

                Console.Write("An error has occured: " + e.ToString());
            }

         }
     }
 }
