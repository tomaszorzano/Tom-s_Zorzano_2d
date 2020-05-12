using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosJardin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((this.txtUsuario.Text == "admin" || this.txtUsuario.Text == "Admin" || this.txtUsuario.Text == "Admin") && (this.mTextContraseña.Text == "Admin123" || (this.mTextContraseña.Text == "admin123")) || (this.mTextContraseña.Text == "ADMIN123"))
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();

                DialogResult result = frmMenuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al introducir usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mTextContraseña_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir contraseña, por favor ingrese solo 5 letras y 3 numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //letra
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            //borrar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mTextContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                if ((this.txtUsuario.Text == "admin" || this.txtUsuario.Text == "Admin" || this.txtUsuario.Text == "Admin") && (this.mTextContraseña.Text == "Admin123" || (this.mTextContraseña.Text == "admin123")) || (this.mTextContraseña.Text == "ADMIN123"))
                {
                    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();

                    DialogResult result = frmMenuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al introducir usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
