using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesis_Blockchain_VoteSystem
{
    public partial class Login : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Processing.Enrollment Enroller;

        #region capture 

        protected void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Stream stream;

                DataTable dt = new DataTable();
                HuellaDactilar huellaDactilar = new HuellaDactilar();
                dt = PreparandoAcceso.BuscaHuellas(huellaDactilar.conex);

                for(int i=0;i< dt.Rows.Count; i++)
                {
                    string huella = dt.Rows[i][1].ToString();
                    byte[] byteHuella = dt.Rows[i][1] as byte[];
                    stream = new MemoryStream(byteHuella);
                    Template = new DPFP.Template(stream);

                    Verificator.Verify(features, Template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MakeReport($"Huella Aceptada de {dt.Rows[i][0]}");
                        Votacion Votacion = new Votacion();
                        
                        MessageBox.Show(new Form() { TopMost = true },$"Huella Aceptada de { dt.Rows[i][0]}");
                        Votacion.ShowDialog();
                        
                        break;
                    }
                        

                    

                }
                
            }
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }
                

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        } 

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate () {
                StatusText.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate () {
                StatusText.Text = prompt;
            }));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate () {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate () {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
            }));
        }

        private DPFP.Capture.Capture Capturer;

        #region Event Handler
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample _Sample)
        {
            MakeReport("La muestra ha sido capturada");
            SetPrompt("Escanea tu misma huella otra vez");
            DPFP.Sample sample = new DPFP.Sample();
            sample = _Sample;
            Process(_Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("La huella fue removida del lector");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El lector fue tocado");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El Lector de huellas ha sido conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El Lector de huellas ha sido desconectado");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("La calidad de la muestra es BUENA");
            else
                MakeReport("La calidad de la muestra es MALA");
        }
        #endregion

#endregion

        #region normal form
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ingresar_nueva_huella huella = new Ingresar_nueva_huella();
            this.Hide();
            Stop();
            huella.ShowDialog();
            this.Show();
            Start();
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        protected virtual void Init()
        {
            try
            {
                Verificator = new DPFP.Verification.Verification();
                Capturer = new DPFP.Capture.Capture();              // Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;                   // Subscribe for capturing events.
                else
                    SetPrompt("No se pudo iniciar la operación de captura");
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Escanea tu huella usando el lector");
                }
                catch
                {
                    SetPrompt("No se puede iniciar la captura");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("No se puede terminar la captura");
                }
            }
        }
    }
}
