
namespace Tesis_Blockchain_VoteSystem
{
    partial class RevisiondeVotos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultSI = new System.Windows.Forms.Label();
            this.lblResultNO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalVotos = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(513, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO";
            // 
            // lblResultSI
            // 
            this.lblResultSI.AutoSize = true;
            this.lblResultSI.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultSI.Location = new System.Drawing.Point(187, 176);
            this.lblResultSI.Name = "lblResultSI";
            this.lblResultSI.Size = new System.Drawing.Size(71, 28);
            this.lblResultSI.TabIndex = 3;
            this.lblResultSI.Text = "[NUM]";
            this.lblResultSI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultNO
            // 
            this.lblResultNO.AutoSize = true;
            this.lblResultNO.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultNO.Location = new System.Drawing.Point(500, 176);
            this.lblResultNO.Name = "lblResultNO";
            this.lblResultNO.Size = new System.Drawing.Size(71, 28);
            this.lblResultNO.TabIndex = 4;
            this.lblResultNO.Text = "[NUM]";
            this.lblResultNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(273, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Votos Totales:";
            // 
            // lblTotalVotos
            // 
            this.lblTotalVotos.AutoSize = true;
            this.lblTotalVotos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVotos.Location = new System.Drawing.Point(410, 71);
            this.lblTotalVotos.Name = "lblTotalVotos";
            this.lblTotalVotos.Size = new System.Drawing.Size(71, 28);
            this.lblTotalVotos.TabIndex = 6;
            this.lblTotalVotos.Text = "[NUM]";
            this.lblTotalVotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RevisiondeVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTotalVotos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultNO);
            this.Controls.Add(this.lblResultSI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RevisiondeVotos";
            this.Text = "RevisiondeVotos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultSI;
        private System.Windows.Forms.Label lblResultNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalVotos;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}