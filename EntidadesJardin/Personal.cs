using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public abstract class Personal : Persona
    {
        #region Atributos
        private DateTime _HoraEntrada;
        private DateTime _HoraSalida;
        #endregion

        #region Propiedades

        public DateTime HoraEntrada { get { return this._HoraEntrada; } set { this._HoraEntrada = value; } }
        public DateTime HoraSalida { get { return this._HoraSalida; } set { this._HoraSalida = value; } }
        public double Salario
        {
            get { return CalcularSalario(); }

        }

        #endregion

        #region Constructores
        protected Personal()
        {

        }
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base(nombre, apellido, dni, femenino)
        {
            this._HoraEntrada = horaEntrada;
            this._HoraSalida = horaSalida;
        }
        #endregion

        #region Metodos
        protected abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hora de entrada: {this._HoraEntrada}");
            sb.AppendLine($"Hora de salida: {this._HoraSalida}");
            return sb.ToString();
        }
        #endregion
    }
}
