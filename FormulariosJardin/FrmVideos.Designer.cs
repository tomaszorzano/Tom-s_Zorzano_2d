namespace FormulariosJardin
{
    partial class FrmVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideos));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPArar = new System.Windows.Forms.Button();
            this.buttonPausa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxVideos = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(5, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(572, 378);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnReproducir
            // 
            this.btnReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.Location = new System.Drawing.Point(149, 388);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(130, 25);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPArar
            // 
            this.btnPArar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPArar.Location = new System.Drawing.Point(294, 388);
            this.btnPArar.Name = "btnPArar";
            this.btnPArar.Size = new System.Drawing.Size(138, 25);
            this.btnPArar.TabIndex = 3;
            this.btnPArar.Text = "Parar";
            this.btnPArar.UseVisualStyleBackColor = true;
            this.btnPArar.Click += new System.EventHandler(this.btnPArar_Click);
            // 
            // buttonPausa
            // 
            this.buttonPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPausa.Location = new System.Drawing.Point(438, 388);
            this.buttonPausa.Name = "buttonPausa";
            this.buttonPausa.Size = new System.Drawing.Size(129, 25);
            this.buttonPausa.TabIndex = 4;
            this.buttonPausa.Text = "Pausa";
            this.buttonPausa.UseVisualStyleBackColor = true;
            this.buttonPausa.Click += new System.EventHandler(this.buttonPausa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // comboBoxVideos
            // 
            this.comboBoxVideos.FormattingEnabled = true;
            this.comboBoxVideos.Location = new System.Drawing.Point(12, 419);
            this.comboBoxVideos.Name = "comboBoxVideos";
            this.comboBoxVideos.Size = new System.Drawing.Size(130, 21);
            this.comboBoxVideos.TabIndex = 5;
            this.comboBoxVideos.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideos_SelectedIndexChanged);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(12, 388);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(130, 25);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.comboBoxVideos);
            this.Controls.Add(this.buttonPausa);
            this.Controls.Add(this.btnPArar);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVideos";
            this.Load += new System.EventHandler(this.FrmVideos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPArar;
        private System.Windows.Forms.Button buttonPausa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxVideos;
        private System.Windows.Forms.Button BtnCerrar;
    }
}