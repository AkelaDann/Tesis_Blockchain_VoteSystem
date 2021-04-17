using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesis_Blockchain_VoteSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Votacion Votacion = new Votacion();
            this.Hide();
            Votacion.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RevisiondeVotos VerVotos = new RevisiondeVotos();
            this.Hide();
            VerVotos.ShowDialog();
            this.Show();
        }

        private void onfocus_txtRut(object sender, EventArgs e)
        {
            txtRut.ResetText();            
        }
        private void onfocus_txtPass(object sender, EventArgs e)
        {
            txtPass.ResetText();
            txtPass.UseSystemPasswordChar= true;
        }
    }
}
