
namespace Tesis_Blockchain_VoteSystem
{
    partial class Ingresar_nueva_huella
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_huella = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_huella = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(267, 98);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(94, 29);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(37, 56);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 20);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_huella
            // 
            this.txt_huella.Location = new System.Drawing.Point(136, 99);
            this.txt_huella.Name = "txt_huella";
            this.txt_huella.Size = new System.Drawing.Size(125, 27);
            this.txt_huella.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(136, 53);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(125, 27);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_huella
            // 
            this.lbl_huella.AutoSize = true;
            this.lbl_huella.Location = new System.Drawing.Point(37, 102);
            this.lbl_huella.Name = "lbl_huella";
            this.lbl_huella.Size = new System.Drawing.Size(52, 20);
            this.lbl_huella.TabIndex = 4;
            this.lbl_huella.Text = "Huella";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(37, 145);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 29);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_lista
            // 
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Location = new System.Drawing.Point(37, 189);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.RowHeadersWidth = 51;
            this.dgv_lista.RowTemplate.Height = 29;
            this.dgv_lista.Size = new System.Drawing.Size(324, 166);
            this.dgv_lista.TabIndex = 6;
            // 
            // Ingresar_nueva_huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 375);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_huella);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_huella);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_registrar);
            this.Name = "Ingresar_nueva_huella";
            this.Text = "Ingresar_nueva_huella";
            this.Load += new System.EventHandler(this.Ingresar_nueva_huella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_huella;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_huella;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_lista;
    }
}