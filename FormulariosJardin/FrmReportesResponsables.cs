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
using System.IO;
using System.Diagnostics;

namespace FormulariosJardin
{
    public partial class FrmReportesResponsables : Form
    {
        List<Alumno> salNaranja = new List<Alumno>();
        List<Alumno> salAmarilla = new List<Alumno>();
        List<Alumno> salVerde = new List<Alumno>();
        List<Alumno> salRojo = new List<Alumno>();
        EColores colorsala;

        public FrmReportesResponsables(List<Alumno> salNaranja, List<Alumno> salAmarilla, List<Alumno> salVerde, List<Alumno> salRojo)
        {
            InitializeComponent();
            this.salNaranja = salNaranja;
            this.salAmarilla = salAmarilla;
            this.salVerde = salVerde;
            this.salRojo = salRojo;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto |*.txt";
            guardar.Title = "Informacion Responsables";
            guardar.FileName = "Informacion responsable por aula";
            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object item in listBoxResponsables.Items)
                {
                    escribir.WriteLine(item.ToString());
                }
                escribir.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Documento de texto |*.txt";
            abrir.Title = "Informacion Responsables";
            abrir.FileName = "Informacion responsable por aula";
            var resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                richTextBoxInfoPadres.Text = leer.ReadToEnd();
                leer.Close();
                   
            }
        }

        private void FrmReportesResponsables_Load(object sender, EventArgs e)
        {
            comboBoxAulas.DataSource = Enum.GetValues(typeof(EColores));
        }

        private void comboBoxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxAulas.SelectedIndex;
            switch (index)
            {
                case 0:
                    listBoxResponsables.DataSource = null;
                    //foreach (Alumno alumnoAux in salNaranja)
                    //{
                    //    comboBoxAulas.Items.Add(alumnoAux.obtenerInforesp());
                    //}
                    listBoxResponsables.DataSource = salNaranja;
                    break;
                case 1:
                    listBoxResponsables.DataSource = null;
                    //foreach (Alumno alumnoAux in salAmarilla)
                    //{
                    //    comboBoxAulas.Items.Add(alumnoAux.obtenerInforesp());
                    //}
                    listBoxResponsables.DataSource = salAmarilla;
                    break;
                case 2:
                    listBoxResponsables.DataSource = null;
                    //foreach (Alumno alumnoAux in salVerde)
                    //{
                    //    comboBoxAulas.Items.Add(alumnoAux.obtenerInforesp());
                    //}
                    listBoxResponsables.DataSource = salVerde;
                    break;
                case 3:
                    listBoxResponsables.DataSource = null;
                    //foreach (Alumno alumnoAux in salRojo)
                    //{
                    //    comboBoxAulas.Items.Add(alumnoAux.obtenerInforesp());
                    //}
                    listBoxResponsables.DataSource = salRojo;
                    break;

                default:
                    break;
            }
        }
    }
}
