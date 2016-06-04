using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class clsCliente
    {
        private string _Nombre;

        public clsCliente(string pNombre)
        {
            Nombre = pNombre;
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        
    }
}
