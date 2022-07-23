using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parseos_Net
{
    class ListaTamano
    {
        String sNombre;
        int iTamano;
        int iPosIni;
        int iPosFin;

        public String Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public int Tamano
        {
            get { return iTamano; }
            set { iTamano = value; }
        }

        public int PosIni
        {
            get { return iPosIni; }
            set { iPosIni = value; }
        }

        public int PosFin
        {
            get { return iPosFin; }
            set { iPosFin = value; }
        }
    }
}
