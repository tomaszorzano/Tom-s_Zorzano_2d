using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosJardin
{
    public partial class FrmResponsable : FrmPersona
    {
        Responsable responsableNuevo;
        public Responsable ResponsableNuevo { get { return this.responsableNuevo; } }
        public FrmResponsable()
        {
            InitializeComponent();
            cmbParentezco.DataSource = Enum.GetValues(typeof(EParentezco));
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir telefono, por favor escriba solo numeros con el formato 11-xxxx-xxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            bool femenino = true;

            if (this.checkBoxMasculino.Checked)
            {
                femenino = false;
            }
            EParentezco nuevoparentezco = (EParentezco)Enum.Parse(typeof(EParentezco), this.cmbParentezco.Text);

            this.responsableNuevo = new Responsable(this.textNombre.Text,
                                                    this.txtApellido.Text,
                                                    Convert.ToInt32(this.mTextDni.Text),
                                                    femenino,
                                                    nuevoparentezco,
                                                    this.mTextTelefono.Text);
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            simpleSound.Play();
            MessageBox.Show($"Responsable: {responsableNuevo.ToString()}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
