using BlockchainLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tesis_Blockchain_VoteSystem
{
    public partial class Votacion : Form
    {
        private string _si = "SI", _no = "NO";
        public Votacion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnSI_Click(object sender, EventArgs e)
        {
            
            Program.VoteChain.CreateTransaction(new Transaction( _si));
            Program.VoteChain.ProcessPendingTransactions(_si);
            Program.Client.Broadcast(JsonConvert.SerializeObject(Program.VoteChain));
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            Program.VoteChain.CreateTransaction(new Transaction(_no));
            Program.VoteChain.ProcessPendingTransactions(_no);
            Program.Client.Broadcast(JsonConvert.SerializeObject(Program.VoteChain));
            this.Close();
        }
    }
}
