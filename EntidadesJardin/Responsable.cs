using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJardin
{
    public enum EParentezco
    {
        Madre,
        Padre,
        Tia,
        Tio,
        Abuela,
        Abuelo,
        Otro
    }

    public class Responsable : Persona
    {

        #region Atributos
        private EParentezco _Parentezco;
        private string _Telefono;


        #endregion

        #region Propiedades
        public EParentezco Parentezco { get { return this._Parentezco; } set { this._Parentezco = value; } }
        public string Telefono { get { return this._Telefono; } set { this._Telefono = value; } }

        #endregion

        #region Constructores
        public Responsable(string nombre,
                            string apellido,
                            int dni,
                            bool femenino,
                            EParentezco parentezco,
                            string telefono)
                           : base(nombre, apellido, dni, femenino)
        {
            this._Parentezco = parentezco;
            this._Telefono = telefono;
        }

        #endregion

        #region Metodos
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Parentezco: {this._Parentezco}");
        //    sb.AppendLine($"Telefono: {this._Telefono}");
        //    return sb.ToString();
        //}

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " +Convert.ToString(this.Parentezco);
        }

        public string obtenerInfo()
        {   
            return this.Nombre + " " + this.Apellido + " " + this.Telefono;
        }

        #endregion
    }
}
