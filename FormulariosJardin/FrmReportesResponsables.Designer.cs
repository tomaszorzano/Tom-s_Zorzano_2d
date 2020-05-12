namespace FormulariosJardin
{
    partial class FrmReportesResponsables
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
            this.richTextBoxInfoPadres = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.listBoxResponsables = new System.Windows.Forms.ListBox();
            this.comboBoxAulas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBoxInfoPadres
            // 
            this.richTextBoxInfoPadres.HideSelection = false;
            this.richTextBoxInfoPadres.Location = new System.Drawing.Point(250, 12);
            this.richTextBoxInfoPadres.Name = "richTextBoxInfoPadres";
            this.richTextBoxInfoPadres.Size = new System.Drawing.Size(218, 353);
            this.richTextBoxInfoPadres.TabIndex = 0;
            this.richTextBoxInfoPadres.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(26, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(300, 379);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(143, 38);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listBoxResponsables
            // 
            this.listBoxResponsables.FormattingEnabled = true;
            this.listBoxResponsables.Location = new System.Drawing.Point(4, 49);
            this.listBoxResponsables.Name = "listBoxResponsables";
            this.listBoxResponsables.Size = new System.Drawing.Size(240, 316);
            this.listBoxResponsables.TabIndex = 3;
            // 
            // comboBoxAulas
            // 
            this.comboBoxAulas.FormattingEnabled = true;
            this.comboBoxAulas.Location = new System.Drawing.Point(4, 22);
            this.comboBoxAulas.Name = "comboBoxAulas";
            this.comboBoxAulas.Size = new System.Drawing.Size(240, 21);
            this.comboBoxAulas.TabIndex = 4;
            this.comboBoxAulas.Text = "Aulas";
            this.comboBoxAulas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAulas_SelectedIndexChanged);
            // 
            // FrmReportesResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 419);
            this.Controls.Add(this.comboBoxAulas);
            this.Controls.Add(this.listBoxResponsables);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richTextBoxInfoPadres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportesResponsables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmReportesResponsables";
            this.Load += new System.EventHandler(this.FrmReportesResponsables_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfoPadres;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listBoxResponsables;
        private System.Windows.Forms.ComboBox comboBoxAulas;
    }
}