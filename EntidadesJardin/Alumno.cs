using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
        public enum EColores
        {
            Naranja,
            Amarillo,
            Verde,
            Rojo
        }
    public class Alumno : Persona
    {

        #region Atributos
        private EColores _ColorSala;
        private int _Legajo;
        private float __PrecioCuota;
        private Responsable _Responsable;
        private int edad;
        private string salaAsignada;

        #endregion

        #region Propiedades

        public EColores ColorSala { get { return this._ColorSala; } set { this._ColorSala = value; } }
        public int Legajo { get { return this._Legajo; } set { this._Legajo = value; } }
        public float PrecioCuota { get { return this.__PrecioCuota; } set { this.__PrecioCuota = value; } }
        public Responsable Responsable { get { return this._Responsable; } set { this._Responsable = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public string SalaAsignada { get { return this.salaAsignada; } set { this.salaAsignada = value; } }

        #endregion

        #region Constructores
        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota, Responsable responsable, int edad, string aulaAsignada) : base(nombre, apellido, dni, femenino)
        {
            this.__PrecioCuota = precioCuota;
            this._Responsable = responsable;
            this.edad = edad;
            this.salaAsignada = aulaAsignada;
        }
        #endregion

        #region Metodos
        public static implicit operator Responsable(Alumno al)
        {

            return al._Responsable;

        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Color sala: {this._ColorSala}");
        //    sb.AppendLine($"Legajo: {this._Legajo}");
        //    sb.AppendLine($"Precio cuota: {this.__PrecioCuota}");
        //    sb.AppendLine($"Precio cuota: {this._Responsable}");
        //    return sb.ToString();
        //}
        public override string ToString()
        {
            return "Alumno: " +this.Nombre + " " + this.Apellido + " " +Convert.ToString(this.Dni) + " " + "Responsable: " + obtenerInforesp();
        }

        public string obtenerInforesp()
        {
            return _Responsable.obtenerInfo();
            }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            bool retorno = false;

            
                if (alumno1.Legajo == alumno2._Legajo)
                {
                    retorno = true;
                    
                }
            
            return retorno;
        }
        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return (!(alumno1 == alumno2));
        }

        #endregion
    }
}
