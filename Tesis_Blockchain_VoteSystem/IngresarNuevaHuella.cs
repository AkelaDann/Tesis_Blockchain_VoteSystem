using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tesis_Blockchain_VoteSystem
{
    public partial class Ingresar_nueva_huella : Form
    {
        private DPFP.Template Template;
        HuellaDactilar huella = new HuellaDactilar();
        public Ingresar_nueva_huella()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            this.Hide();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
            this.Show();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btn_agregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    txt_huella.Text = "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            btn_agregarHuella();
            Template = null;
            txt_huella.Text = "";
            txt_nombre.Text = "";
            btn_agregar.Enabled = false;
            
        }

        private void btn_agregarHuella()
        {
            huella.huella = Template.Bytes;
            huella.nombre = txt_nombre.Text;
            string conex = huella.conex;
            PreparandoAcceso.InsertaHuella(huella, conex);
            llenarDataGridView();
        }

        private void Ingresar_nueva_huella_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void llenarDataGridView()
        {
            DataTable dt = new DataTable();
            string conex = huella.conex;
            dt = PreparandoAcceso.BuscaListado(conex);

            dgv_lista.DataSource = dt;
            dgv_lista.Refresh();
        }
    }
}
