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
        private byte _Edad;

        public clsCliente(string pNombre,byte pEdad)
        {
            Nombre = pNombre;
            Edad = pEdad;
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public byte Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        
    }
}
