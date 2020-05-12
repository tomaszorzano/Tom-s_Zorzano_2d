using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public class Docente : Personal
    {
        #region Atributos
        private double _ValorHora;
        private bool aulaAsignada = false;
        #endregion

        #region Propiedades
        public double ValorHora { get { return this._ValorHora; } set { this._ValorHora = value; } }
        public int HorasMensuales
        {
            get
            {
                int aux;
                TimeSpan span = HoraSalida.Subtract(HoraEntrada);
                aux = span.Hours * 20;
                return aux;
            }
        }

        public bool AulaAsignada { get { return this.aulaAsignada; } set { this.aulaAsignada = value; } }

        #endregion

        #region Constructores
        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora, bool aulaasignada) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this._ValorHora = valorHora;
            this.aulaAsignada = aulaasignada;
        }

        
        #endregion



        #region Metodos
        protected override double CalcularSalario()
        {
            return (double)HorasMensuales * this._ValorHora;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Valor hora: {this._ValorHora}");
        //    return sb.ToString();
        //}
        public string NombreCompletoDocente()
        {
            return this.Nombre +" " + this.Apellido + " " + Convert.ToString(this.CalcularSalario());
        }
        #endregion
    }
}
