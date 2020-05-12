    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public enum Eturno
    {
        Mañana,
        Tarde
    }

    public class Aula
    {
        #region Atributos
        private List<Alumno> _Alumnos;
        private EColores _ColorSala;
        private Docente _Docente;
        private Eturno _Turno;
        private float recaudaciontotal = 0;
        #endregion

        #region Propiedades

        public List<Alumno> Alumnos { get { return this._Alumnos; } set { this._Alumnos = value; } }
        public EColores ColorSala { get { return this._ColorSala; } set { this._ColorSala = value; } }
        public Docente Docente { get { return this._Docente; } set { this._Docente = value; } }
        public Eturno Turno { get { return this._Turno; } set { this._Turno = value; } }

        public float Recaudaciontotal { get { return this.recaudaciontotal; } set { this.recaudaciontotal = value; } }
        #endregion

        #region Constructores
        public Aula(EColores colorSala, Eturno turno, Docente docente, float recaudacion)
        {
            this._Alumnos = new List<Alumno>(30);
            this._Docente = docente;
            this._Turno = turno;
            this._ColorSala = colorSala;
            this.recaudaciontotal = recaudacion;
        }
        #endregion

        #region Metodos
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"Color: {this._ColorSala}");
        //    sb.AppendLine($"Docente: {this._Docente}");
        //    sb.AppendLine($"Turno: {this._Turno}");
        //    return sb.ToString();
        //}
        public override string ToString()
        {
            return "Color: " + this._ColorSala + " " + "Docente: " + this._Docente + " " + "Turno: " + this._Turno;
        }

        public string AulaRecaudacion()
        {
            return this.ToString() + "Recaudacion: " + Convert.ToString(this.recaudaciontotal);
        }
        #endregion

        #region Sobrecargas
        public static bool operator + (Aula aula, Alumno alumno)
        {
            bool retorno = false;

            if (!(alumno is null))
            {
                
                aula._Alumnos.Add(alumno);
            }
            return retorno;
        }
        
        #endregion
    }
}
