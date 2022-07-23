using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parseos_Net
{
    class ListaParseoDatos
    {
        String sNombre;
        String sDato;

        public String Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public String Dato
        {
            get { return sDato; }
            set { sDato = value; }
        }
    }
}
