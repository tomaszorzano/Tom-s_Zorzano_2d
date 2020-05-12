using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public enum ECargo
    {
        Portería = 100,
        Cocina = 110,
        Secretaría = 140,
        Tesorería = 240,
        Direccion = 180

    }
    public class Administrativo : Personal
    {
        

        #region Atributos
        private ECargo _Cargo;
        public static double _SalarioBase;
        #endregion

        #region Propiedades
        public ECargo Cargo { get { return this._Cargo; } set { this._Cargo = value; } }
        #endregion

        #region Constructores
        static Administrativo()
        {
            _SalarioBase = 30000;
        }
        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this._Cargo = cargo;
        }
        #endregion

        #region Metodos
        protected override double CalcularSalario()
        {
            double aux;
            int valorEnum = (int)this._Cargo; ; 
            aux = (_SalarioBase * valorEnum) / 100;

            return aux;
        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Cargo: {this._Cargo}");
        //    return sb.ToString();
        //}

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + Convert.ToString(this.Cargo);
        }
        public string NombreCompletoAdmin()
        {
            return this.Nombre + " " + this.Apellido + " " + Convert.ToString(this.CalcularSalario());
        }
        #endregion
    }
}
