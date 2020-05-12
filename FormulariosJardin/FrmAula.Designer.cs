namespace FormulariosJardin
{
    partial class FrmAula
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
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.listBoxAlumnosSinAula = new System.Windows.Forms.ListBox();
            this.listBoxAlumnosEnAula = new System.Windows.Forms.ListBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAlumnosAsignados = new System.Windows.Forms.Label();
            this.lblAlumnosSinAsignar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(58, 17);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(99, 21);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.Text = "Colores";
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(178, 20);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(44, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(243, 17);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(99, 21);
            this.cmbTurno.TabIndex = 3;
            this.cmbTurno.Text = "Turno";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(370, 20);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(91, 13);
            this.lblProfesor.TabIndex = 4;
            this.lblProfesor.Text = "Docente Libre:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(478, 15);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(152, 21);
            this.cmbProfesor.TabIndex = 5;
            this.cmbProfesor.Text = "Docentes Libres";
            // 
            // listBoxAlumnosSinAula
            // 
            this.listBoxAlumnosSinAula.AllowDrop = true;
            this.listBoxAlumnosSinAula.FormattingEnabled = true;
            this.listBoxAlumnosSinAula.Location = new System.Drawing.Point(287, 57);
            this.listBoxAlumnosSinAula.Name = "listBoxAlumnosSinAula";
            this.listBoxAlumnosSinAula.Size = new System.Drawing.Size(343, 381);
            this.listBoxAlumnosSinAula.TabIndex = 7;
            this.listBoxAlumnosSinAula.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxAlumnosSinAula_MouseDown);
            // 
            // listBoxAlumnosEnAula
            // 
            this.listBoxAlumnosEnAula.AllowDrop = true;
            this.listBoxAlumnosEnAula.FormattingEnabled = true;
            this.listBoxAlumnosEnAula.Location = new System.Drawing.Point(12, 57);
            this.listBoxAlumnosEnAula.Name = "listBoxAlumnosEnAula";
            this.listBoxAlumnosEnAula.Size = new System.Drawing.Size(225, 381);
            this.listBoxAlumnosEnAula.TabIndex = 6;
            this.listBoxAlumnosEnAula.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxAlumnosEnAula_DragDrop);
            this.listBoxAlumnosEnAula.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxAlumnosEnAula_DragEnter);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(387, 456);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(143, 36);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(94, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAlumnosAsignados
            // 
            this.lblAlumnosAsignados.AutoSize = true;
            this.lblAlumnosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosAsignados.Location = new System.Drawing.Point(12, 41);
            this.lblAlumnosAsignados.Name = "lblAlumnosAsignados";
            this.lblAlumnosAsignados.Size = new System.Drawing.Size(148, 16);
            this.lblAlumnosAsignados.TabIndex = 10;
            this.lblAlumnosAsignados.Text = "Alumnos asignados:";
            // 
            // lblAlumnosSinAsignar
            // 
            this.lblAlumnosSinAsignar.AutoSize = true;
            this.lblAlumnosSinAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosSinAsignar.Location = new System.Drawing.Point(284, 41);
            this.lblAlumnosSinAsignar.Name = "lblAlumnosSinAsignar";
            this.lblAlumnosSinAsignar.Size = new System.Drawing.Size(151, 16);
            this.lblAlumnosSinAsignar.TabIndex = 11;
            this.lblAlumnosSinAsignar.Text = "Alumnos sin asignar:";
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 500);
            this.Controls.Add(this.lblAlumnosSinAsignar);
            this.Controls.Add(this.lblAlumnosAsignados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.listBoxAlumnosSinAula);
            this.Controls.Add(this.listBoxAlumnosEnAula);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAula";
            this.Text = "Aula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ListBox listBoxAlumnosSinAula;
        private System.Windows.Forms.ListBox listBoxAlumnosEnAula;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAlumnosAsignados;
        private System.Windows.Forms.Label lblAlumnosSinAsignar;
    }
}