using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SomaticStore.Server
{
    public class Server
    {
        public Server()
        {}

        public void Listen()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint endpoint = new IPEndPoint(ipAddress, 14241);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(endpoint);
                listener.Listen(100);
            }
            catch (Exception e)
            {
                // TODO: implement logging
                Console.WriteLine(e.ToString());
            }
        }
    }
}
