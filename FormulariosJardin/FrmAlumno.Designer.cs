namespace FormulariosJardin
{
    partial class FrmAlumno
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.mTextLegajo = new System.Windows.Forms.MaskedTextBox();
            this.mTextCuota = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnResponsable = new System.Windows.Forms.Button();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblResponsableCargado = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.mTextEdad = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(285, 270);
            // 
            // mTextDni
            // 
            this.mTextDni.Location = new System.Drawing.Point(67, 122);
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.Location = new System.Drawing.Point(194, 165);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(297, 33);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(60, 16);
            this.lblLegajo.TabIndex = 11;
            this.lblLegajo.Text = "Legajo:";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(297, 79);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(123, 16);
            this.lblCuota.TabIndex = 12;
            this.lblCuota.Text = "Precio de Cuota:";
            // 
            // mTextLegajo
            // 
            this.mTextLegajo.Location = new System.Drawing.Point(363, 33);
            this.mTextLegajo.Mask = "99999";
            this.mTextLegajo.Name = "mTextLegajo";
            this.mTextLegajo.Size = new System.Drawing.Size(36, 20);
            this.mTextLegajo.TabIndex = 13;
            this.mTextLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTextLegajo.ValidatingType = typeof(int);
            this.mTextLegajo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextLegajo_MaskInputRejected);
            // 
            // mTextCuota
            // 
            this.mTextCuota.Location = new System.Drawing.Point(426, 75);
            this.mTextCuota.Mask = "99999";
            this.mTextCuota.Name = "mTextCuota";
            this.mTextCuota.Size = new System.Drawing.Size(37, 20);
            this.mTextCuota.TabIndex = 14;
            this.mTextCuota.ValidatingType = typeof(int);
            this.mTextCuota.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextCuota_MaskInputRejected);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(76, 271);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 37);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnResponsable
            // 
            this.btnResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponsable.Location = new System.Drawing.Point(314, 164);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(135, 41);
            this.btnResponsable.TabIndex = 17;
            this.btnResponsable.Text = "Cargar Responsable";
            this.btnResponsable.UseVisualStyleBackColor = true;
            this.btnResponsable.Click += new System.EventHandler(this.btnResponsable_Click);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(29, 220);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(105, 16);
            this.lblResponsable.TabIndex = 19;
            this.lblResponsable.Text = "Responsable:";
            // 
            // lblResponsableCargado
            // 
            this.lblResponsableCargado.AutoSize = true;
            this.lblResponsableCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsableCargado.Location = new System.Drawing.Point(140, 220);
            this.lblResponsableCargado.Name = "lblResponsableCargado";
            this.lblResponsableCargado.Size = new System.Drawing.Size(99, 16);
            this.lblResponsableCargado.TabIndex = 20;
            this.lblResponsableCargado.Text = "Sin Informacion";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(297, 116);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(49, 16);
            this.lbledad.TabIndex = 22;
            this.lbledad.Text = "Edad:";
            // 
            // mTextEdad
            // 
            this.mTextEdad.Location = new System.Drawing.Point(357, 112);
            this.mTextEdad.Mask = "99";
            this.mTextEdad.Name = "mTextEdad";
            this.mTextEdad.Size = new System.Drawing.Size(20, 20);
            this.mTextEdad.TabIndex = 23;
            this.mTextEdad.ValidatingType = typeof(int);
            this.mTextEdad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextEdad_MaskInputRejected);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 332);
            this.Controls.Add(this.mTextEdad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblResponsableCargado);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.btnResponsable);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mTextCuota);
            this.Controls.Add(this.mTextLegajo);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.lblLegajo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblGenero, 0);
            this.Controls.SetChildIndex(this.textNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.mTextDni, 0);
            this.Controls.SetChildIndex(this.CheckBFemenino, 0);
            this.Controls.SetChildIndex(this.checkBoxMasculino, 0);
            this.Controls.SetChildIndex(this.lblLegajo, 0);
            this.Controls.SetChildIndex(this.lblCuota, 0);
            this.Controls.SetChildIndex(this.mTextLegajo, 0);
            this.Controls.SetChildIndex(this.mTextCuota, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnResponsable, 0);
            this.Controls.SetChildIndex(this.lblResponsable, 0);
            this.Controls.SetChildIndex(this.lblResponsableCargado, 0);
            this.Controls.SetChildIndex(this.lbledad, 0);
            this.Controls.SetChildIndex(this.mTextEdad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.MaskedTextBox mTextLegajo;
        private System.Windows.Forms.MaskedTextBox mTextCuota;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblResponsableCargado;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.MaskedTextBox mTextEdad;
    }
}