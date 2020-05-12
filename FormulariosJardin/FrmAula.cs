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
using FormulariosJardin;
using System.Media;

namespace FormulariosJardin
{
    public partial class FrmAula : Form
    {

        FrmMenuPrincipal frmMenuPrincipalc = new FrmMenuPrincipal();
        List<Alumno> salaNaranja = new List<Alumno>();
        List<Alumno> salaAmarilla = new List<Alumno>();
        List<Alumno> salaVerde = new List<Alumno>();
        List<Alumno> salaRoja = new List<Alumno>();
        List<Docente> docentes = new List<Docente>();
        List<Alumno> alumnosSinAulas = new List<Alumno>();
        List<Alumno> alumnosConAulas = new List<Alumno>();
        private int indexDocente1;
        private float recaudaciontotalAula = 0;
        Aula aulaNueva;

        public Aula AulaNueva { get { return this.aulaNueva; } }

        public int IndexDocente1 { get { return this.indexDocente1; } }

        public float RecaudaciontotalAula { get { return this.recaudaciontotalAula; } }

        public FrmAula(List<Docente> docentes, List<Alumno> salaNaranja, List<Alumno> salaAmarilla, List<Alumno> salaVerde, List<Alumno> salaRoja)
        {
            InitializeComponent();
            cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurno.DataSource = Enum.GetValues(typeof(Eturno));
            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = docentes;
            this.docentes = docentes;
            this.salaNaranja = salaNaranja;
            this.salaAmarilla = salaAmarilla;
            this.salaVerde = salaVerde;
            this.salaRoja = salaRoja;



        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cmbColor.SelectedIndex;
            


            switch (index)
            {

                case 0:
                    this.BackColor = Color.Orange;
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    foreach (Alumno alumnoAux in salaNaranja)
                    {
                        if (alumnoAux.SalaAsignada == "Sin")
                        {
                            alumnosSinAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosSinAulas;
                        }
                        else if (alumnoAux.SalaAsignada == "Naranja")
                        {
                            alumnosConAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosConAulas;
                        }

                    }
                    break;
                case 1:
                    this.BackColor = Color.Yellow;
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    foreach (Alumno alumnoAux in salaAmarilla)
                    {
                        if (alumnoAux.SalaAsignada == "Sin")
                        {
                            alumnosSinAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosSinAulas;
                        }
                        else if (alumnoAux.SalaAsignada == "Amarrila")
                        {
                            alumnosConAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosConAulas;
                        }
                    }
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;
                    foreach (Alumno alumnoAux in salaVerde)
                    {

                        if (alumnoAux.SalaAsignada == "Sin")
                        {
                            alumnosSinAulas.Add(alumnoAux);


                            listBoxAlumnosSinAula.DataSource = alumnosSinAulas;
                        }
                        else if (alumnoAux.SalaAsignada == "Verde")
                        {
                            alumnosConAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosConAulas;
                        }
                    }
                    break;
                case 3:
                    this.BackColor = Color.Red;
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    foreach (Alumno alumnoAux in salaRoja)
                    {
                        if (alumnoAux.SalaAsignada == "Sin")
                        {
                            alumnosSinAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosSinAulas;
                        }
                        else if (alumnoAux.SalaAsignada == "Rojo")
                        {
                            alumnosConAulas.Add(alumnoAux);

                            listBoxAlumnosSinAula.DataSource = alumnosConAulas;
                        }
                    }
                    break;
                default:
                    break;
            }


        }

        private void FrmAula_Load(object sender, EventArgs e)
        {


            cmbProfesor.DataSource = null;
            cmbProfesor.DataSource = docentes;

        }

        private void listBoxAlumnosEnAula_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBoxAlumnosSinAula_MouseDown(object sender, MouseEventArgs e)
        {

            listBoxAlumnosEnAula.DoDragDrop(listBoxAlumnosSinAula.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBoxAlumnosEnAula_DragDrop(object sender, DragEventArgs e)
        {
            listBoxAlumnosEnAula.Items.Add(e.Data.GetData(DataFormats.Text));

            int indexSala = cmbColor.SelectedIndex;


            switch (indexSala)
            {
                case 0:
                    int index = IndexAlumno(listBoxAlumnosSinAula.SelectedItem.ToString(), salaNaranja);
                    salaNaranja[index].SalaAsignada = "Naranja";
                    MessageBox.Show(salaNaranja[index].ToString());
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    break;
                case 1:
                    int indexa = IndexAlumno(listBoxAlumnosSinAula.SelectedItem.ToString(), salaAmarilla);
                    salaAmarilla[indexa].SalaAsignada = "Amarillo";
                    MessageBox.Show(salaAmarilla[indexa].ToString());
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    break;
                case 2:
                    int indexb = IndexAlumno(listBoxAlumnosSinAula.SelectedItem.ToString(), salaVerde);
                    salaVerde[indexb].SalaAsignada = "Verde";
                    MessageBox.Show(salaVerde[indexb].ToString());
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    break;
                case 3:
                    int indexc = IndexAlumno(listBoxAlumnosSinAula.SelectedItem.ToString(), salaRoja);
                    salaRoja[indexc].SalaAsignada = "Rojo";
                    MessageBox.Show(salaRoja[indexc].ToString());
                    listBoxAlumnosSinAula.DataSource = null;
                    listBoxAlumnosEnAula.DataSource = null;

                    break;
                default:
                    break;
            }

        }

        public int IndexAlumno(string str, List<Alumno> alumnosSala)
        {
            int retorno = -1;
            foreach (Alumno aulumnoaux in alumnosSala)
            {
                for (int i = 0; i < alumnosSala.Count; i++)
                {

                    if (aulumnoaux.ToString() == str)
                    {
                        retorno = i;
                    }
                }

            }
            return retorno;
        }

        public int IndexDocente(string str, List<Docente> docenteSala)
        {
            int retorno = -1;
            foreach (Docente docenteAux in docenteSala)
            {
                for (int i = 0; i < docenteSala.Count; i++)
                {

                    if (docenteAux.ToString() == str)
                    {
                        retorno = i;
                    }
                }

            }
            return retorno;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //EParentezco nuevoparentezco = (EParentezco)Enum.Parse(typeof(EParentezco), this.cmbParentezco.Text);
            EColores nuevoColor = (EColores)Enum.Parse(typeof(EColores),this.cmbColor.Text);
            Eturno nuevoTurno = (Eturno)Enum.Parse(typeof(Eturno), this.cmbTurno.Text);
            string docenteNuevo = Convert.ToString(this.cmbProfesor.Text);
            int index = IndexDocente(docenteNuevo, docentes);
            indexDocente1 = index;

            
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\notify.wav");
            simpleSound.Play();
            
            this.DialogResult = DialogResult.OK;

            foreach (Alumno alumnoaux in alumnosConAulas)
            {

                recaudaciontotalAula = RecaudaciontotalAula + (alumnoaux.PrecioCuota);
            }
            this.aulaNueva = new Aula(nuevoColor, nuevoTurno, docentes[index], recaudaciontotalAula);
            MessageBox.Show($"Aula: {aulaNueva.ToString()}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show($"Aula: {recaudaciontotalAula}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
