
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockchainLib;
using ServiceManager;

namespace Tesis_Blockchain_VoteSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static int Port =FindFreePort();
        public static P2PServer Server = null;
        public static P2PClient Client = new P2PClient();
        public static Blockchain VoteChain = new Blockchain();

        [STAThread]
        static void Main()
        {
            //if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Count() <= 3)
            //{
            //    Process.Start("Tesis_Blockchain_VoteSystem.exe");
            //}
            VoteChain.InitializeChain();
            if (Server == null)
            {
                Server = new P2PServer();
                Server.Start(Program.Port);
            }
            else
            {
                Client.Connect(Server.url+"/BlockChain");
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static int FindFreePort()
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
