using System;
using System.Net;
using System.Net.PeerToPeer;
using System.Net.Sockets;
using System.ServiceModel;

namespace ServiceManager
{
    public class PeerConfigurationService 
    {

        public int FindFreePort()
        {
            int port;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
            {
                socket.Bind(endPoint);
                IPEndPoint local = (IPEndPoint)socket.LocalEndPoint;
                port = local.Port;
            }
            if (port == 0)
            {
                throw new ArgumentNullException(nameof(port));
            } 
                
            return port;
        }
    }
}
