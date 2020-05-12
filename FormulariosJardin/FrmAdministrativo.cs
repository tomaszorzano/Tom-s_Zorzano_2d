using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosJardin
{
    public partial class FrmAdministrativo : FrmPersona
    {
        EntidadesJardin.Administrativo administrativoNuevo;

        public EntidadesJardin.Administrativo AdministrativoNuevo { get { return this.administrativoNuevo; } }
        public FrmAdministrativo()
        {
            InitializeComponent();
            cmbCargo.DataSource = Enum.GetValues(typeof(ECargo));
        }


        private void mtextSalarioBase_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir salario base, por favor escriba solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool femenino = true;

            if (this.checkBoxMasculino.Checked)
            {
                femenino = false;
            }
            ECargo cargonuevo = (ECargo)Enum.Parse(typeof(ECargo), this.cmbCargo.Text);

            this.administrativoNuevo = new Administrativo(this.textNombre.Text,
                                                           this.txtApellido.Text,
                                                           Convert.ToInt32(this.mTextDni.Text),
                                                           femenino,
                                                           Convert.ToDateTime(this.mTextHsEntrada.Text),
                                                           Convert.ToDateTime(this.mTextHsSalida.Text),
                                                           cargonuevo);

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            simpleSound.Play();
            MessageBox.Show($"Administrativo: {administrativoNuevo.ToString()}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void mTextHsEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir hora de entrada, por favor escriba la hora con el siguiente formato 00:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mTextHsSalida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir hora de salida, por favor escriba la hora con el siguiente formato 00:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
