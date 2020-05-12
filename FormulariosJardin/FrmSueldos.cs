using EntidadesJardin;
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
    public partial class FrmSueldos : Form
    {
        List<Docente> docentes = new List<Docente>();
        List<Administrativo> administrativos = new List<Administrativo>();
        public FrmSueldos(List<Docente> docentes, List<Administrativo> administrativos)
        {
            InitializeComponent();
            this.docentes = docentes;
            this.administrativos = administrativos;
        }

        private void listBoxSueldosDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {






        }



        private void FrmSueldos_Load(object sender, EventArgs e)
        {

            foreach (Docente docenteaux in docentes)
            {
                listBoxSueldosDocentes.Items.Add(docenteaux.NombreCompletoDocente());

            }
            foreach (Administrativo adminAux in administrativos)
            {

                listBoxAdministrativos.Items.Add(adminAux.NombreCompletoAdmin());
            }
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
