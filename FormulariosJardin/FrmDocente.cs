using EntidadesJardin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosJardin
{
    public partial class FrmDocente : FrmPersona
    {
        Docente docenteNuevo;

        public FrmDocente()
        {
            InitializeComponent();

        }

        public Docente DocenteNuevo { get { return this.docenteNuevo; } }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
            bool femenino = true;
            if (this.checkBoxMasculino.Checked)
            {
                femenino = false;
            }


            this.docenteNuevo = new Docente(this.textNombre.Text,
                                       this.txtApellido.Text,
                                       Convert.ToInt32(this.mTextDni.Text),
                                       femenino,
                                       Convert.ToDateTime(this.MTextNHsEntrada.Text),
                                       Convert.ToDateTime(this.MTextHsSalida.Text),
                                       Convert.ToDouble(this.mTextValorHS.Text),
                                       false);

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            simpleSound.Play();
            MessageBox.Show($"Docente: {docenteNuevo.ToString()}","Satifactorio",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;

        }

        private void MTextNHsEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir hora de entrada, por favor escriba la hora con el siguiente formato 00:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MTextHsSalida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir hora de salida, por favor escriba la hora con el siguiente formato 00:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mTextValorHS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir valor de su hora, por favor escriba solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
