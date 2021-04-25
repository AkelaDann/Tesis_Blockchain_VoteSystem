using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace BlockchainLib
{
    public class P2PServer: WebSocketBehavior
    {
        bool chainSynched = false;
        WebSocketServer wss = null;
        public string url = "";

        public void Start(int port)
        {
            wss = new WebSocketServer($"ws://127.0.0.1:{port}");
            wss.AddWebSocketService<P2PServer>("/Blockchain");
            wss.Start();
            Console.WriteLine($"Started server at ws://127.0.0.1:{port}");
            url = $"ws://127.0.0.1:{port}";
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data == "Hi Server")
            {
                Console.WriteLine(e.Data);
                Send("Hi Client");
            }
            else
            {
                Blockchain newChain = JsonConvert.DeserializeObject<Blockchain>(e.Data);

                if (newChain.IsValid() && newChain.Chain.Count > Tesis_Blockchain_VoteSystem.Program.VoteChain.Chain.Count)
                {
                    List<Transaction> newTransactions = new List<Transaction>();
                    newTransactions.AddRange(newChain.PendingTransactions);
                    newTransactions.AddRange(Tesis_Blockchain_VoteSystem.Program.VoteChain.PendingTransactions);

                    newChain.PendingTransactions = newTransactions;
                    Tesis_Blockchain_VoteSystem.Program.VoteChain = newChain;
                }

                if (!chainSynched)
                {
                    Send(JsonConvert.SerializeObject(Tesis_Blockchain_VoteSystem.Program.VoteChain));
                    chainSynched = true;
                }
            }
        }
    }
}
