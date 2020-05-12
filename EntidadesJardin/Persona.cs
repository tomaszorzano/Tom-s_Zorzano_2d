using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public abstract class Persona
    {
        #region Atributos
        private string _Nombre;
        private int _Dni;
        private bool _Femenino;
        private string _Apellido;
        #endregion

        #region Propiedades

        public string Nombre { get { return this._Nombre; } set { this._Nombre = value; } }
        public int Dni { get { return this._Dni; } set { this._Dni = value; } }
        public bool Femenino { get { return this._Femenino; } set { this._Femenino = value; } }
        public string Apellido { get { return this._Apellido; } set { this._Apellido = value; } }

        #endregion

        #region Constructores
        protected Persona()
        {

        }
        protected Persona(string nombre, string apellido, int dni)
        {
            this._Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }
        protected Persona(string nombre, string apellido, int dni, bool femenino) : this(nombre, apellido, dni)
        {
            this._Femenino = femenino;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this._Nombre}");
            sb.AppendLine($"Apellido: {this._Apellido}");
            sb.AppendLine($"Dni: {this._Dni}");
            return sb.ToString();
        }
        #endregion
    }
}
