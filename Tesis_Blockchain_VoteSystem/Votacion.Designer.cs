
namespace Tesis_Blockchain_VoteSystem
{
    partial class Votacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button BtnSI;
            this.label1 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            BtnSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSI
            // 
            BtnSI.Location = new System.Drawing.Point(299, 153);
            BtnSI.Name = "BtnSI";
            BtnSI.Size = new System.Drawing.Size(189, 58);
            BtnSI.TabIndex = 1;
            BtnSI.Text = "Si";
            BtnSI.UseVisualStyleBackColor = true;
            BtnSI.Click += new System.EventHandler(this.BtnSI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Estás de acuerdo con la nueva constitución?";
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(299, 250);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(189, 58);
            this.btnNO.TabIndex = 2;
            this.btnNO.Text = "No";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Votacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(BtnSI);
            this.Controls.Add(this.label1);
            this.Name = "Votacion";
            this.Text = "Esta de acuerdo con la nueva Constitucion?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}