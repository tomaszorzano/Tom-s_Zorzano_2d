namespace FormulariosJardin
{
    partial class FrmResponsable
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
            this.lblParentezco = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mTextTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(315, 215);
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.Location = new System.Drawing.Point(185, 163);
            // 
            // lblParentezco
            // 
            this.lblParentezco.AutoSize = true;
            this.lblParentezco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentezco.Location = new System.Drawing.Point(298, 32);
            this.lblParentezco.Name = "lblParentezco";
            this.lblParentezco.Size = new System.Drawing.Size(90, 16);
            this.lblParentezco.TabIndex = 10;
            this.lblParentezco.Text = "Parentezco:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(298, 83);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 16);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono:";
            // 
            // mTextTelefono
            // 
            this.mTextTelefono.Location = new System.Drawing.Point(394, 79);
            this.mTextTelefono.Mask = "00-0000-0000";
            this.mTextTelefono.Name = "mTextTelefono";
            this.mTextTelefono.Size = new System.Drawing.Size(72, 20);
            this.mTextTelefono.TabIndex = 12;
            this.mTextTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Location = new System.Drawing.Point(394, 31);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(99, 21);
            this.cmbParentezco.TabIndex = 13;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(99, 215);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(135, 38);
            this.BtnAceptar.TabIndex = 14;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 264);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.mTextTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblParentezco);
            this.Name = "FrmResponsable";
            this.Text = "Responsable";
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
            this.Controls.SetChildIndex(this.lblParentezco, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.mTextTelefono, 0);
            this.Controls.SetChildIndex(this.cmbParentezco, 0);
            this.Controls.SetChildIndex(this.BtnAceptar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParentezco;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mTextTelefono;
        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.Button BtnAceptar;
    }
}