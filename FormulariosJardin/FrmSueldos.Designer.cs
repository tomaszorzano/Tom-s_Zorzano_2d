namespace FormulariosJardin
{
    partial class FrmSueldos
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
            this.listBoxSueldosDocentes = new System.Windows.Forms.ListBox();
            this.lblSueldosDocentes = new System.Windows.Forms.Label();
            this.lblSueldosNoDocentes = new System.Windows.Forms.Label();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.listBoxAdministrativos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSueldosDocentes
            // 
            this.listBoxSueldosDocentes.FormattingEnabled = true;
            this.listBoxSueldosDocentes.Location = new System.Drawing.Point(4, 37);
            this.listBoxSueldosDocentes.Name = "listBoxSueldosDocentes";
            this.listBoxSueldosDocentes.Size = new System.Drawing.Size(306, 342);
            this.listBoxSueldosDocentes.TabIndex = 0;
            this.listBoxSueldosDocentes.SelectedIndexChanged += new System.EventHandler(this.listBoxSueldosDocentes_SelectedIndexChanged);
            // 
            // lblSueldosDocentes
            // 
            this.lblSueldosDocentes.AutoSize = true;
            this.lblSueldosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldosDocentes.Location = new System.Drawing.Point(1, 18);
            this.lblSueldosDocentes.Name = "lblSueldosDocentes";
            this.lblSueldosDocentes.Size = new System.Drawing.Size(161, 16);
            this.lblSueldosDocentes.TabIndex = 2;
            this.lblSueldosDocentes.Text = "Sueldos de Docentes:";
            // 
            // lblSueldosNoDocentes
            // 
            this.lblSueldosNoDocentes.AutoSize = true;
            this.lblSueldosNoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldosNoDocentes.Location = new System.Drawing.Point(313, 18);
            this.lblSueldosNoDocentes.Name = "lblSueldosNoDocentes";
            this.lblSueldosNoDocentes.Size = new System.Drawing.Size(201, 16);
            this.lblSueldosNoDocentes.TabIndex = 3;
            this.lblSueldosNoDocentes.Text = "Sueldos de Administrativos:";
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrrar.Location = new System.Drawing.Point(235, 385);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Size = new System.Drawing.Size(143, 42);
            this.BtnCerrrar.TabIndex = 4;
            this.BtnCerrrar.Text = "Cerrrar";
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // listBoxAdministrativos
            // 
            this.listBoxAdministrativos.FormattingEnabled = true;
            this.listBoxAdministrativos.Location = new System.Drawing.Point(316, 37);
            this.listBoxAdministrativos.Name = "listBoxAdministrativos";
            this.listBoxAdministrativos.Size = new System.Drawing.Size(306, 342);
            this.listBoxAdministrativos.TabIndex = 5;
            // 
            // FrmSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 433);
            this.Controls.Add(this.listBoxAdministrativos);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.lblSueldosNoDocentes);
            this.Controls.Add(this.lblSueldosDocentes);
            this.Controls.Add(this.listBoxSueldosDocentes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSueldos";
            this.Load += new System.EventHandler(this.FrmSueldos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSueldosDocentes;
        private System.Windows.Forms.Label lblSueldosDocentes;
        private System.Windows.Forms.Label lblSueldosNoDocentes;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.ListBox listBoxAdministrativos;
    }
}