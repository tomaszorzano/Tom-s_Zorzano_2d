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
    public partial class FrmAlumno : FrmPersona
    {

        Alumno alumnoNuevo;
        FrmResponsable _FrmResponsable;
        int cargoResp = 0;
        public Alumno AlumnoNuevo { get { return this.alumnoNuevo; } }
        public FrmAlumno()
        {
            InitializeComponent();
            _FrmResponsable = new FrmResponsable();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        { 

        }
        private void mTextLegajo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir el legajo, por favor escriba solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mTextCuota_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir el valor de la cuota, por favor escriba solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cargoResp == 0)
            {
                MessageBox.Show("Falta cargar responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
                bool femenino = true;

                if (this.checkBoxMasculino.Checked)
                {
                    femenino = false;
                }

                this.alumnoNuevo = new Alumno(this.textNombre.Text,
                                              this.txtApellido.Text,
                                              Convert.ToInt32(this.mTextDni.Text),
                                              femenino,
                                              Convert.ToInt64(this.mTextCuota.Text),
                                              this._FrmResponsable.ResponsableNuevo,
                                              Convert.ToInt32(this.mTextEdad.Text),
                                              "Sin"
                                              );
                

                SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\notify.wav");
                simpleSound.Play();
                MessageBox.Show($"{alumnoNuevo.ToString()}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            DialogResult result = _FrmResponsable.ShowDialog();
            if (result == DialogResult.OK)
            {
                cargoResp = 1;
                lblResponsableCargado.Text = this._FrmResponsable.ResponsableNuevo.ToString();
            }
        }

        private void mTextEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir la edad, por favor escriba solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
