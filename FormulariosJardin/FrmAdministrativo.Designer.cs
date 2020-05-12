namespace FormulariosJardin
{
    partial class FrmAdministrativo
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblHSEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextHsEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mTextHsSalida = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(277, 235);
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.Location = new System.Drawing.Point(185, 165);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(261, 33);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(54, 16);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(394, 33);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(79, 21);
            this.cmbCargo.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(99, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 38);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblHSEntrada
            // 
            this.lblHSEntrada.AutoSize = true;
            this.lblHSEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSEntrada.Location = new System.Drawing.Point(264, 80);
            this.lblHSEntrada.Name = "lblHSEntrada";
            this.lblHSEntrada.Size = new System.Drawing.Size(125, 16);
            this.lblHSEntrada.TabIndex = 15;
            this.lblHSEntrada.Text = "Hora de entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hora de salida:";
            // 
            // mTextHsEntrada
            // 
            this.mTextHsEntrada.Location = new System.Drawing.Point(395, 78);
            this.mTextHsEntrada.Mask = "00:00";
            this.mTextHsEntrada.Name = "mTextHsEntrada";
            this.mTextHsEntrada.Size = new System.Drawing.Size(36, 20);
            this.mTextHsEntrada.TabIndex = 17;
            this.mTextHsEntrada.ValidatingType = typeof(System.DateTime);
            this.mTextHsEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextHsEntrada_MaskInputRejected);
            // 
            // mTextHsSalida
            // 
            this.mTextHsSalida.Location = new System.Drawing.Point(394, 118);
            this.mTextHsSalida.Mask = "00:00";
            this.mTextHsSalida.Name = "mTextHsSalida";
            this.mTextHsSalida.Size = new System.Drawing.Size(36, 20);
            this.mTextHsSalida.TabIndex = 18;
            this.mTextHsSalida.ValidatingType = typeof(System.DateTime);
            this.mTextHsSalida.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextHsSalida_MaskInputRejected);
            // 
            // FrmAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 285);
            this.Controls.Add(this.mTextHsSalida);
            this.Controls.Add(this.mTextHsEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHSEntrada);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdministrativo";
            this.Text = "Administrativo";
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
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.cmbCargo, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblHSEntrada, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.mTextHsEntrada, 0);
            this.Controls.SetChildIndex(this.mTextHsSalida, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblHSEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTextHsEntrada;
        private System.Windows.Forms.MaskedTextBox mTextHsSalida;
    }
}