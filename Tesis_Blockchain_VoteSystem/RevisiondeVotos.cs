using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tesis_Blockchain_VoteSystem
{
    public partial class RevisiondeVotos : Form
    {
        Login log = new Login();

        private int _S = 0, _N = 0;
        public RevisiondeVotos()
        {
            InitializeComponent();
            _N=Program.VoteChain.GetBalanceNo();
            _S = Program.VoteChain.GetBalanceSi();
            lblResultSI.Text = _S.ToString();
            lblResultNO.Text = _N.ToString();
            lblTotalVotos.Text = (_N + _S).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
