using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesJardin;

namespace FormulariosJardin
{
    public partial class FrmMenuPrincipal : Form
    {

        private List<Docente> _Docentes;
        public List<Alumno> _Alumnos;
        public List<Alumno> _AlumnosNaranja;
        public List<Alumno> _AlumnosAmarillo;
        public List<Alumno> _AlumnosVerde;
        public List<Alumno> _AlumnosRojo;
        public List<Administrativo> _Administrativos;
        public List<Aula> _Aulas;
        private List<Docente> _DocentesLibres;
        int cargoaula = 0;
        int cargoDocente = 0;
        int cargoAdministrativo = 0;



        public List<Docente> DocentesLibres { get { return this._DocentesLibres; } }

        public List<Docente> Docentes { get { return this._Docentes; } }

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            _Docentes = new List<Docente>();
            _Alumnos = new List<Alumno>();
            _AlumnosNaranja = new List<Alumno>();
            _AlumnosAmarillo = new List<Alumno>();
            _AlumnosVerde = new List<Alumno>();
            _AlumnosRojo = new List<Alumno>();
            _Administrativos = new List<Administrativo>();
            _Aulas = new List<Aula>();
            _DocentesLibres = new List<Docente>();

            

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FrmRecaudacion _FrmRecaudacion = new FrmRecaudacion();
            _FrmRecaudacion.MdiParent = this;



        }



        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDocente _FrmDocente = new FrmDocente();

            DialogResult result = _FrmDocente.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CargarlistaDocente(_FrmDocente.DocenteNuevo);
                cargoDocente = 1;
                
            }
        }
        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno _FrmAlumno = new FrmAlumno();

            DialogResult result = _FrmAlumno.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CargarlistaAlumnos(_FrmAlumno.AlumnoNuevo);

            }
        }
        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrativo _FrmAdministrativo = new FrmAdministrativo();
            DialogResult result = _FrmAdministrativo.ShowDialog();
            if (result == DialogResult.OK)
            {
                cargoAdministrativo = 1;
                this.CargarlistaAdministrativos(_FrmAdministrativo.AdministrativoNuevo);
               
                
            }
        }
        private void aulaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cargoDocente == 1)
            {
                FrmAula _FrmAulas = new FrmAula(_DocentesLibres, _AlumnosNaranja, _AlumnosAmarillo, _AlumnosVerde, _AlumnosRojo);
                DialogResult result = _FrmAulas.ShowDialog();
                if (result == DialogResult.OK)
                {

                    this.ListBoxAula.Items.Add(_FrmAulas.AulaNueva.ToString());
                    DocentesLibres[_FrmAulas.IndexDocente1].AulaAsignada = true;

                    _DocentesLibres.Remove(_DocentesLibres[_FrmAulas.IndexDocente1]);

                    MessageBox.Show($"Aula: {_FrmAulas.AulaNueva.AulaRecaudacion()}", "Satifactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargoaula = 1;
                }
            }
            else
            {
                MessageBox.Show("Error por favor cargar un docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        public void CargarlistaDocente(Docente docente)
        {
            
            this.Docentes.Add(docente);
            foreach (Docente docenteAux in _Docentes)
            {
                if (docenteAux.AulaAsignada == false)
                {
                    this.DocentesLibres.Add(docenteAux);
                }

            }

        }
        public void CargarlistaAlumnos(Alumno alumno)
        {
            this._Alumnos.Add(alumno);
            foreach (Alumno alumnoAux in _Alumnos)
            {
                if (alumnoAux.Edad == 3)
                {
                    this._AlumnosNaranja.Add(alumnoAux);
                }
                if (alumnoAux.Edad == 4)
                {
                    this._AlumnosAmarillo.Add(alumnoAux);
                }
                if (alumnoAux.Edad == 5 || alumnoAux.Edad == 6)
                {
                    this._AlumnosVerde.Add(alumnoAux);
                }
                if (alumnoAux.Edad == 2)
                {
                    this._AlumnosRojo.Add(alumnoAux);
                }

            }
        }
        public void CargarlistaAdministrativos(Administrativo administrativo)
        {
            
            this._Administrativos.Add(administrativo);
        }
        public void CargarlistaAulas(Aula aula)
        {
            this._Aulas.Add(aula);
        }

             
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informacionPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargoaula == 1)
            {

                FrmReportesResponsables _FrmReportesResponsables = new FrmReportesResponsables(_AlumnosNaranja, _AlumnosAmarillo, _AlumnosVerde, _AlumnosRojo);
                _FrmReportesResponsables.MdiParent = this;

                _FrmReportesResponsables.Show();
            }
            else
            {
               
            }
        }

        private void ListBoxAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (cargoDocente == 1 && cargoAdministrativo == 1)
            {
                
                FrmSueldos _FrmSueldos = new FrmSueldos(_Docentes,_Administrativos);
                _FrmSueldos.MdiParent = this;
                _FrmSueldos.Show();

            }
            else
            {
                MessageBox.Show("Error por favor cargar Docentes y Administrativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void reproducirVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmVideos frmVideos = new FrmVideos();
            DialogResult result = frmVideos.ShowDialog();
            if (result == DialogResult.OK)
            { 

            }
        }

        //private void harcodearDatosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DateTime hE = DateTime.Now;
        //    DateTime hS = DateTime.Now ;
        //    hS.AddHours(02);

        //    #region Alumnos
        //    CargarlistaAlumnos(new Alumno("Federico", "Zorzano", 0200, false, 23525400, new Responsable("David", "Zorzano", 1100, false, EParentezco.Padre, "1122323"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Cristian", "Zorzano", 00010, false, 20053210, new Responsable("Juan", "Zorzano", 1713500, false, EParentezco.Abuela, "1124223"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Carolina", "Zorzano", 00010, true, 2154000, new Responsable("Sofia", "Zorzano", 1514700, false, EParentezco.Abuelo, "114223"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Joaquin", "Zorzano", 00030, true, 2016300, new Responsable("Esteban", "Zorzano", 1751400, false, EParentezco.Tio, "11314223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("David", "Perez", 00005, true, 25641000, new Responsable("Manuel", "Perez", 173400, false, EParentezco.Madre, "15511223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Gonzalo", "Perez", 003400, false, 254000, new Responsable("Sabrina", "Perez", 134700, false, EParentezco.Padre, "1124423"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Damian", "Perez", 000230, false, 207600, new Responsable("Margarita", "Perez", 1712400, false, EParentezco.Padre, "11214223"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Camila", "Perez", 0005530, true, 782098400, new Responsable("Martina", "Perez", 143700, false, EParentezco.Padre, "11232|23"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Sofia", "Perez", 000065, true, 208700, new Responsable("Agustin", "Perez", 170530, false, EParentezco.Padre, "112234|3"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Nicolas", "Perez", 008900, true, 206700, new Responsable("Pedro", "Gonzales", 170530, false, EParentezco.Padre, "1123464223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Tomas", "Gonzales", 0008070, false, 207500, new Responsable("Juan luis", "Gonzales", 171300, false, EParentezco.Padre, "154261223"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Natalia", "Gonzales", 000450, false, 205400, new Responsable("Daniela", "Gonzales", 153700, false, EParentezco.Padre, "1123723"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Fernando", "Gonzales", 000320, true, 2089500, new Responsable("Dai", "Gonzales", 1714500, false, EParentezco.Padre, "1175477223"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Julieta", "Gonzales", 000340, true, 2008700, new Responsable("Ricardo", "Gonzales", 170450, false, EParentezco.Padre, "1125223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Maria", "Gonzales", 0002130, true, 20947600, new Responsable("Susana", "Gonzales", 1705514320, false, EParentezco.Padre, "11755728223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Benjamin", "Gonzales", 0446000, false, 298000, new Responsable("Bernardo", "Gonzales", 1352700, false, EParentezco.Padre, "11265323"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Paola", "Garcia", 0000512, false, 2005980, new Responsable("Milton", "Dominguez", 511700, false, EParentezco.Padre, "1124574823"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Diego", "Garcia", 003400, true, 2000087, new Responsable("Maximiliano", "Dominguez", 1705230, false, EParentezco.Padre, "11297323"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Felipe", "Garcia", 00345600, true, 240507680, new Responsable("Hernan", "Dominguez", 1754100, false, EParentezco.Padre, "115462223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Ignacio", "Garcia", 0003240, true, 462000, new Responsable("Santiago", "Dominguez", 1715300, false, EParentezco.Padre, "1122535723"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Juan", "Garcia", 000970, false, 2645000, new Responsable("Carla", "Dominguez", 173500, false, EParentezco.Padre, "1123754223"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Lorenzo", "Garcia", 067000, false, 247000, new Responsable("Ailen", "Dominguez", 176400, false, EParentezco.Padre, "112425654223"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Simon", "Dominguez", 00675400, true, 5722000, new Responsable("Agustina", "Garcia", 176300, false, EParentezco.Padre, "116542223"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Alma", "Dominguez", 0003570, true, 2008650, new Responsable("Mabel", "Garcia", 1701640, false, EParentezco.Padre, "1146613223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Emma", "Dominguez", 000356890, true, 205600, new Responsable("Victoria", "Garcia", 198253700, false, EParentezco.Padre, "6431644116"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Ana", "Dominguez", 005786200, false, 2032100, new Responsable("Pilar", "Garcia", 170146430, false, EParentezco.Padre, "112246436413"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Laura", "Dominguez", 000970, false, 20046310, new Responsable("Natalia", "Garcia", 1714656400, false, EParentezco.Padre, "112276345423"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Adiana", "Dominguez", 0000, true, 2435000, new Responsable("Joel", "Garcia", 17461400, false, EParentezco.Padre, "11542754223"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Pamela", "Dominguez", 00007456, true, 2000, new Responsable("Emir", "Garcia", 17464100, false, EParentezco.Padre, "11257524223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Cristina", "Lopez", 000453230, true, 41552000, new Responsable("Jeremias", "Garcia", 11464700, false, EParentezco.Padre, "2546254662"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Isabela", "Lopez", 0000543, false, 20054150, new Responsable("Leonardo", "Lopez", 176146400, false, EParentezco.Padre, "11262454623"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Evelin", "Lopez", 000420, false, 208700, new Responsable("Manuel", "Lopez", 1523123700, false, EParentezco.Padre, "1127545423"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Monica", "Lopez", 0065700, true, 201500, new Responsable("Tomas", "Lopez", 523532, false, EParentezco.Padre, "1122547524723"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Diana", "Lopez", 0004350, true, 2004150, new Responsable("Francisco", "Lopez", 15532523, false, EParentezco.Padre, "1124622623"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Daiana", "Aguero", 004500, true, 20615614300, new Responsable("Roberto", "Lopez", 51523645, false, EParentezco.Padre, "1164251223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Adriana", "Lopez", 004500, false, 203500, new Responsable("Ciro", "Lopez", 567, false, EParentezco.Padre, "1126423"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Bruno", "Lopez", 0001450, false, 2061300, new Responsable("Lola", "Lopez", 436323, false, EParentezco.Padre, "114162123"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Bernardo", "Larreta", 01456000, true, 642000, new Responsable("Emma", "Lopez", 1257574700, false, EParentezco.Padre, "1113264223"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Fabian", "Larreta", 0001240, true, 2045040, new Responsable("Juana", "Lopez", 17043250, false, EParentezco.Padre, "11146223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Lucia", "Larreta", 0003450, true, 200150, new Responsable("Rufina", "Lopez", 646644, false, EParentezco.Padre, "1146111223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Martina", "Larreta", 01352000, false, 647512000, new Responsable("Marcela", "Lopez", 6262364, false, EParentezco.Padre, "116414223"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Pedro", "Larreta", 0004510, false, 20542700, new Responsable("Gaston", "Aguero", 1644700, false, EParentezco.Padre, "1122146463"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Ana Ines", "Larreta", 0014500, true, 203400, new Responsable("Bestia", "Aguero", 623623, false, EParentezco.Padre, "11216446123"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Julia", "Aguero", 0003450, true, 2013500, new Responsable("Chiqui", "Aguero", 6464426, false, EParentezco.Padre, "112613523"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Martin", "Aguero", 001500, true, 204513500, new Responsable("Tapia", "Aguero", 6464, false, EParentezco.Padre, "11235223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Marcos", "Aguero", 0005332520, false, 205327500, new Responsable("Bilardo", "Aguero", 1616414, false, EParentezco.Padre, "1153153223"), 5, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Manuel", "Aguero", 0003540, false, 200349500, new Responsable("Sergio", "Aguero", 1152315700, false, EParentezco.Padre, "115134223"), 4, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Nicolas", "Aguero", 000530, true, 2046200, new Responsable("Carlos", "Aguero", 170014, false, EParentezco.Padre, "11216543123"), 3, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Lucas", "Aguero", 00075850, true, 2008650, new Responsable("Cristiano", "Aguero", 151132700, false, EParentezco.Padre, "11135223"), 2, "Sin"));
        //    CargarlistaAlumnos(new Alumno("Clara", "Aguero", 0007960, true, 203200, new Responsable("Paulo", "Aguero", 1715351200, false, EParentezco.Padre, "11264236123"), 2, "Sin"));
        //    #endregion
        //    #region Docentes
        //    CargarlistaDocente(new Docente("Ricardo", "Bochini", 39911686, false, hE, hS, 200, false));
        //    CargarlistaDocente(new Docente("Daniel", "Bertoni", 3991168, false, hE, hS, 500, false));
        //    CargarlistaDocente(new Docente("Arsenio", "Erico", 399116, false, hE, hS, 100, false));
        //    CargarlistaDocente(new Docente("Antonio", "Sastre", 39911, false, hE, hS, 30, false));
        //    CargarlistaDocente(new Docente("Miguel Angel", "Santoro", 311686, false, hE, hS, 340, false));
        //    CargarlistaDocente(new Docente("Sergio", "Aguero", 399186, false, hE, hS, 3100, false));
        //    CargarlistaDocente(new Docente("Nicolas", "Tagliafico", 91686, false, hE, hS, 250, false));
        //    CargarlistaDocente(new Docente("Ezequiel", "Barco", 3918, false, hE, hS, 220, false));
        //    CargarlistaDocente(new Docente("Diego Armando", "Mardona", 99118, false, hE, hS, 110, false));
        //    CargarlistaDocente(new Docente("Lionel", "Messi", 3916, false, hE, hS, 289, false));

        //    #endregion

        //    #region Administrativo
        //    CargarlistaAdministrativos(new Administrativo("Juan", "Torres", 3999112, false, hE, hS, ECargo.Cocina));
        //    CargarlistaAdministrativos(new Administrativo("Juan Luis", "Gonzalez", 399112, false, hE, hS, ECargo.Direccion));
        //    CargarlistaAdministrativos(new Administrativo("Luis Juan", "Sabina", 39912, false, hE, hS, ECargo.Portería));
        //    CargarlistaAdministrativos(new Administrativo("Gabriel", "Milito", 9912, false, hE, hS, ECargo.Secretaría));
        //    CargarlistaAdministrativos(new Administrativo("Manuel", "Perez", 39113462, false, hE, hS, ECargo.Tesorería));
        //    #endregion

        //}
    }
}
