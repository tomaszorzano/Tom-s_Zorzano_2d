namespace FormulariosJardin
{
    partial class FrmDocente
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblHsEntrada = new System.Windows.Forms.Label();
            this.lblHsSalida = new System.Windows.Forms.Label();
            this.lblValorHs = new System.Windows.Forms.Label();
            this.MTextNHsEntrada = new System.Windows.Forms.MaskedTextBox();
            this.MTextHsSalida = new System.Windows.Forms.MaskedTextBox();
            this.mTextValorHS = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(273, 185);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 36);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(9, 79);
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(12, 120);
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(12, 153);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(85, 37);
            this.textNombre.Size = new System.Drawing.Size(127, 20);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 75);
            this.txtApellido.Size = new System.Drawing.Size(127, 20);
            // 
            // mTextDni
            // 
            this.mTextDni.Location = new System.Drawing.Point(85, 120);
            // 
            // CheckBFemenino
            // 
            this.CheckBFemenino.Location = new System.Drawing.Point(89, 154);
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.Location = new System.Drawing.Point(175, 153);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(81, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 37);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblHsEntrada
            // 
            this.lblHsEntrada.AutoSize = true;
            this.lblHsEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsEntrada.Location = new System.Drawing.Point(218, 36);
            this.lblHsEntrada.Name = "lblHsEntrada";
            this.lblHsEntrada.Size = new System.Drawing.Size(114, 15);
            this.lblHsEntrada.TabIndex = 8;
            this.lblHsEntrada.Text = "Hora de Ingreso:";
            // 
            // lblHsSalida
            // 
            this.lblHsSalida.AutoSize = true;
            this.lblHsSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsSalida.Location = new System.Drawing.Point(218, 76);
            this.lblHsSalida.Name = "lblHsSalida";
            this.lblHsSalida.Size = new System.Drawing.Size(107, 15);
            this.lblHsSalida.TabIndex = 10;
            this.lblHsSalida.Text = "Hora de Salida:";
            // 
            // lblValorHs
            // 
            this.lblValorHs.AutoSize = true;
            this.lblValorHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHs.Location = new System.Drawing.Point(218, 116);
            this.lblValorHs.Name = "lblValorHs";
            this.lblValorHs.Size = new System.Drawing.Size(79, 15);
            this.lblValorHs.TabIndex = 13;
            this.lblValorHs.Text = "Valor Hora:";
            // 
            // MTextNHsEntrada
            // 
            this.MTextNHsEntrada.Location = new System.Drawing.Point(343, 36);
            this.MTextNHsEntrada.Mask = "00:00";
            this.MTextNHsEntrada.Name = "MTextNHsEntrada";
            this.MTextNHsEntrada.Size = new System.Drawing.Size(97, 20);
            this.MTextNHsEntrada.TabIndex = 17;
            this.MTextNHsEntrada.ValidatingType = typeof(System.DateTime);
            this.MTextNHsEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTextNHsEntrada_MaskInputRejected);
            // 
            // MTextHsSalida
            // 
            this.MTextHsSalida.Location = new System.Drawing.Point(343, 75);
            this.MTextHsSalida.Mask = "00:00";
            this.MTextHsSalida.Name = "MTextHsSalida";
            this.MTextHsSalida.Size = new System.Drawing.Size(97, 20);
            this.MTextHsSalida.TabIndex = 18;
            this.MTextHsSalida.ValidatingType = typeof(System.DateTime);
            this.MTextHsSalida.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTextHsSalida_MaskInputRejected);
            // 
            // mTextValorHS
            // 
            this.mTextValorHS.Location = new System.Drawing.Point(343, 115);
            this.mTextValorHS.Mask = "99999";
            this.mTextValorHS.Name = "mTextValorHS";
            this.mTextValorHS.Size = new System.Drawing.Size(97, 20);
            this.mTextValorHS.TabIndex = 19;
            this.mTextValorHS.ValidatingType = typeof(int);
            this.mTextValorHS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextValorHS_MaskInputRejected);
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.Controls.Add(this.mTextValorHS);
            this.Controls.Add(this.MTextHsSalida);
            this.Controls.Add(this.MTextNHsEntrada);
            this.Controls.Add(this.lblValorHs);
            this.Controls.Add(this.lblHsSalida);
            this.Controls.Add(this.lblHsEntrada);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblHsEntrada, 0);
            this.Controls.SetChildIndex(this.lblHsSalida, 0);
            this.Controls.SetChildIndex(this.lblValorHs, 0);
            this.Controls.SetChildIndex(this.MTextNHsEntrada, 0);
            this.Controls.SetChildIndex(this.MTextHsSalida, 0);
            this.Controls.SetChildIndex(this.mTextValorHS, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblGenero, 0);
            this.Controls.SetChildIndex(this.textNombre, 0);
            this.Controls.SetChildIndex(this.mTextDni, 0);
            this.Controls.SetChildIndex(this.CheckBFemenino, 0);
            this.Controls.SetChildIndex(this.checkBoxMasculino, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblHsEntrada;
        private System.Windows.Forms.Label lblHsSalida;
        private System.Windows.Forms.Label lblValorHs;
        private System.Windows.Forms.MaskedTextBox MTextNHsEntrada;
        private System.Windows.Forms.MaskedTextBox MTextHsSalida;
        private System.Windows.Forms.MaskedTextBox mTextValorHS;
    }
}