using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
*/

namespace Parseos_Net
{
    class Utiles
    {
        //public int miMax(int v1, int v2)
        //{
        //    int r = 0;
        //    if (v1 > v2)
        //        r = v1;
        //    else
        //        r = v2;
        //    return (r);
        //}

        //public int miMin(int v1, int v2)
        //{
        //    int r = 0;
        //    if (v1 > v2)
        //        r = v2;
        //    else
        //        r = v1;
        //    return (r);
        //}

        public int minimoNoCero(int iValor1, int iValor2)
        {
            int iValor = iValor2;
            if ((iValor1 < iValor2 || iValor2 == 0) && iValor1 != 0 && iValor1 != -1)
            {
                iValor = iValor1;
            }
            return iValor;
        }

        public void parseo(bool bArray, bool rbVB, bool rbC, bool rbSubstring,
                        String sNumElem, String sEstructura, String sData,
                        String sLargoNumerico, String sLargoDolar,
                        out String sSalida, out int iLargoTotal)
        {
            DialogResult dr = new DialogResult();
            int iNumPasadas = 0, iCuantas, k = 0;
            bool flgParseo = true;
            String slinea;
            int iposEspacio;
            int iposTab;
            int iposSquare = 0;
            int ipos1;
            String sNombreVar;
            int iLargo, iLargoMax = 0;
            String sValor;
            String stEstructura;
            int iPosIni = 1;
            iLargoTotal = 0;

            var oSalida = new StringBuilder();
            var clcParseoDatos = new List<ListaParseoDatos>();
            var elem = new ListaParseoDatos();

            if (bArray)
            {
                try
                {
                    iNumPasadas = Convert.ToInt32(sNumElem);
                }
                catch (Exception ex)
                {
                    iNumPasadas = 0;
                }

                if (iNumPasadas == 0)
                {
                    dr = MessageBox.Show("Numero elementos no puede ser cero", "Alerta", MessageBoxButtons.OK);
                    flgParseo = false;
                }
            }
            else
            {
                iNumPasadas = 1;
            }

            oSalida.Length = 0;
            if (flgParseo)
            {
                for (iCuantas = 0; iCuantas < iNumPasadas; iCuantas++)
                {
                    if (bArray)
                    {
                        elem = new ListaParseoDatos();

                        oSalida.Clear();
                        oSalida.Append(String.Concat(Enumerable.Repeat("-", 5)));
                        oSalida.Append("Elemento :");
                        oSalida.Append(iCuantas + 1);
                        oSalida.Append(String.Concat(Enumerable.Repeat("-", 10)));
                        //oSalida.Append(System.Environment.NewLine);

                        elem.Nombre = "";
                        elem.Dato = oSalida.ToString();
                        clcParseoDatos.Add(elem);
                    }
                    stEstructura = sEstructura;
                    k = stEstructura.IndexOf(System.Environment.NewLine);
                    while (k != -1)
                    {
                        slinea = stEstructura.Substring(0, k).Trim();
                        if (slinea.Length > 0)
                        {
                            if (rbVB)
                            {
                                if (slinea.Substring(0, 1) != "'")
                                {
                                    iposEspacio = slinea.IndexOf(" ");
                                    iposTab = slinea.IndexOf((char)9);
                                    iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                                    ipos1 = slinea.IndexOf("*");
                                    sNombreVar = slinea.Substring(0, minimoNoCero(ipos1, iposTab));

                                    sValor = slinea.Substring(ipos1 + 1).Trim();
                                    ipos1 = sValor.IndexOf("'");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(0, ipos1 - 1);
                                    }
                                    if (sValor.IndexOf("LARGO_NUMERICO") > -1)
                                    {
                                        sValor = sLargoNumerico;
                                    }
                                    if (sValor.IndexOf("LARGO_CUPOS_DOLAR") > -1)
                                    {
                                        sValor = sLargoDolar;
                                    }
                                    iLargo = Convert.ToInt32(sValor);
                                    elem = new ListaParseoDatos();
                                    elem.Nombre = sNombreVar;
                                    try
                                    {
                                        elem.Dato = sData.Substring(iPosIni - 1, iLargo);
                                    }
                                    catch (ArgumentOutOfRangeException ex)
                                    {
                                        elem.Dato = "";
                                    }
                                    clcParseoDatos.Add(elem);
                                    elem = null;

                                    iPosIni += iLargo;
                                    iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                                    iLargoTotal += iLargo;
                                }
                            }
                            if (rbC)
                            {
                                if (slinea.Substring(0, 2) != "//")
                                {
                                    iposEspacio = slinea.IndexOf(" ");
                                    iposTab = slinea.IndexOf((char)9);
                                    iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare));
                                    if (iposTab > 0)
                                    {
                                        slinea = slinea.Substring(minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare)) + 1);
                                    }
                                    iposEspacio = slinea.IndexOf(" ");
                                    iposTab = slinea.IndexOf((char)9);
                                    iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare));
                                    ipos1 = slinea.IndexOf("[");

                                    sNombreVar = slinea.Substring(0, minimoNoCero(ipos1, iposTab));

                                    sValor = slinea.Substring(ipos1 + 1).Trim();
                                    ipos1 = sValor.IndexOf("//");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(0, ipos1);
                                    }

                                    ipos1 = sValor.IndexOf("]");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(0, ipos1);
                                    }

                                    iLargo = Convert.ToInt32(sValor);
                                    elem = new ListaParseoDatos();
                                    elem.Nombre = sNombreVar;
                                    try
                                    {
                                        elem.Dato = sData.Substring(iPosIni - 1, iLargo);
                                    }
                                    catch (ArgumentOutOfRangeException ex)
                                    {
                                        elem.Dato = "";
                                    }
                                    clcParseoDatos.Add(elem);
                                    elem = null;

                                    iPosIni += iLargo;
                                    iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                                    iLargoTotal += iLargo;
                                }
                            }
                            if (rbSubstring)
                            {
                                if (slinea.Substring(0, 2) != "--")
                                {
                                    iposEspacio = slinea.IndexOf(" ");
                                    iposTab = slinea.IndexOf((char)9);
                                    iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                                    slinea = slinea.Substring(minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare)) + 1);

                                    iposEspacio = slinea.IndexOf(" ");
                                    iposTab = slinea.IndexOf((char)9);
                                    iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                                    iposSquare = slinea.IndexOf("=");

                                    sNombreVar = slinea.Substring(0, minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare)) - 1);

                                    ipos1 = slinea.ToUpper().IndexOf("SUBSTRING");

                                    sValor = slinea;
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(ipos1);
                                    }
                                    ipos1 = sValor.IndexOf("(");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(ipos1 + 1);
                                    }
                                    ipos1 = sValor.IndexOf(",");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(ipos1 + 1);
                                    }
                                    ipos1 = sValor.IndexOf(",");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(ipos1 + 1);
                                    }
                                    ipos1 = sValor.IndexOf(",");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(ipos1 + 1);
                                    }
                                    ipos1 = sValor.IndexOf(")");
                                    if (ipos1 > -1)
                                    {
                                        sValor = sValor.Substring(0, ipos1);
                                    }
                                    iLargo = Convert.ToInt32(sValor);
                                    elem = new ListaParseoDatos();
                                    elem.Nombre = sNombreVar;
                                    try
                                    {
                                        elem.Dato = sData.Substring(iPosIni - 1, iLargo);
                                    }
                                    catch (ArgumentOutOfRangeException ex)
                                    {
                                        elem.Dato = "";
                                    }
                                    clcParseoDatos.Add(elem);
                                    elem = null;

                                    iPosIni += iLargo;
                                    iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                                    iLargoTotal += iLargo;
                                }
                            }
                        }
                        stEstructura = stEstructura.Substring(k + 2);
                        k = stEstructura.IndexOf(System.Environment.NewLine);
                    }
                }
            }

            iLargoMax = Math.Max(iLargoMax, 20);
            iLargoMax += 2;
            oSalida.Clear();
            foreach (var elemSalida in clcParseoDatos)
            {
                if (elemSalida.Nombre.Length == 0)
                {
                    oSalida.Append(elemSalida.Dato.ToString());
                    oSalida.Append(System.Environment.NewLine);
                }
                else
                {
                    oSalida.Append(elemSalida.Nombre.PadRight(iLargoMax, ' '));
                    oSalida.Append("[");
                    oSalida.Append(elemSalida.Dato.ToString());
                    oSalida.Append("]");
                    oSalida.Append(System.Environment.NewLine);
                }
            }
            sSalida = oSalida.ToString();
        }

        public void Tamanos(String sEstructura, bool rbVB, bool rbC, bool rbSubstring, String sLargoNumerico, String sLargoDolar,
                            out String sSalida)
        {
            int k;
            int iposEspacio;
            int iposTab;
            int iposSquare = 0;
            int ipos1;
            String slinea;
            String sNombreVar;
            int iLargo;
            String sValor;
            String stEstructura;
            int iPosIni = 1;
            int iLargoMax = 0;
            var oSalida = new StringBuilder();
            var clcTamano = new List<ListaTamano>();
            var elem = new ListaTamano();

            stEstructura = sEstructura;
            k = stEstructura.IndexOf(System.Environment.NewLine);
            while (k != -1)
            {
                slinea = stEstructura.Substring(0, k).Trim();
                if (slinea.Length > 0)
                {
                    if (rbVB)
                    {
                        if (slinea.Substring(0, 1) != "'")
                        {
                            iposEspacio = slinea.IndexOf(" ");
                            iposTab = slinea.IndexOf((char)9);
                            iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                            ipos1 = slinea.IndexOf("*");
                            sNombreVar = slinea.Substring(0, minimoNoCero(ipos1, iposTab));

                            sValor = slinea.Substring(ipos1 + 1).Trim();
                            ipos1 = sValor.IndexOf("'");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(0, ipos1 - 1);
                            }
                            if (sValor.IndexOf("LARGO_NUMERICO") > -1)
                            {
                                sValor = sLargoNumerico;
                            }
                            if (sValor.IndexOf("LARGO_CUPOS_DOLAR") > -1)
                            {
                                sValor = sLargoDolar;
                            }
                            iLargo = Convert.ToInt32(sValor);

                            elem = new ListaTamano();
                            elem.Nombre = sNombreVar;
                            elem.Tamano = iLargo;
                            elem.PosIni = iPosIni;
                            elem.PosFin = iPosIni + iLargo - 1;
                            clcTamano.Add(elem);
                            elem = null;
                            iPosIni += iLargo;
                            iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                        }
                    }
                    if (rbC)
                    {
                        if (slinea.Substring(0, 2) != "//")
                        {
                            iposEspacio = slinea.IndexOf(" ");
                            iposTab = slinea.IndexOf((char)9);
                            iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare));
                            if (iposTab > 0)
                            {
                                slinea = slinea.Substring(minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare)) + 1);
                            }
                            iposEspacio = slinea.IndexOf(" ");
                            iposTab = slinea.IndexOf((char)9);
                            iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare));
                            ipos1 = slinea.IndexOf("[");

                            sNombreVar = slinea.Substring(0, minimoNoCero(ipos1, iposTab));

                            sValor = slinea.Substring(ipos1 + 1).Trim();
                            ipos1 = sValor.IndexOf("//");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(0, ipos1);
                            }

                            ipos1 = sValor.IndexOf("]");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(0, ipos1);
                            }

                            iLargo = Convert.ToInt32(sValor);

                            elem = new ListaTamano();
                            elem.Nombre = sNombreVar;
                            elem.Tamano = iLargo;
                            elem.PosIni = iPosIni;
                            elem.PosFin = iPosIni + iLargo - 1;
                            clcTamano.Add(elem);
                            elem = null;
                            iPosIni += iLargo;
                            iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                        }
                    }
                    if (rbSubstring)
                    {
                        if (slinea.Substring(0, 2) != "--")
                        {
                            iposEspacio = slinea.IndexOf(" ");
                            iposTab = slinea.IndexOf((char)9);
                            iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                            slinea = slinea.Substring(minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare)) + 1);

                            iposEspacio = slinea.IndexOf(" ");
                            iposTab = slinea.IndexOf((char)9);
                            iposTab = minimoNoCero(iposEspacio, minimoNoCero(iposEspacio, iposSquare));
                            iposSquare = slinea.IndexOf("=");

                            sNombreVar = slinea.Substring(0, minimoNoCero(iposEspacio, minimoNoCero(iposTab, iposSquare)) - 1);

                            ipos1 = slinea.ToUpper().IndexOf("SUBSTRING");

                            sValor = slinea;
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(ipos1);
                            }
                            ipos1 = sValor.IndexOf("(");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(ipos1 + 1);
                            }
                            ipos1 = sValor.IndexOf(",");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(ipos1 + 1);
                            }
                            ipos1 = sValor.IndexOf(",");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(ipos1 + 1);
                            }
                            ipos1 = sValor.IndexOf(",");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(ipos1 + 1);
                            }
                            ipos1 = sValor.IndexOf(")");
                            if (ipos1 > -1)
                            {
                                sValor = sValor.Substring(0, ipos1);
                            }
                            iLargo = Convert.ToInt32(sValor);

                            elem = new ListaTamano();
                            elem.Nombre = sNombreVar;
                            elem.Tamano = iLargo;
                            elem.PosIni = iPosIni;
                            elem.PosFin = iPosIni + iLargo - 1;
                            clcTamano.Add(elem);
                            elem = null;
                            iPosIni += iLargo;
                            iLargoMax = Math.Max(iLargoMax, sNombreVar.Length);
                        }
                    }
                }

                stEstructura = stEstructura.Substring(k + 2);
                k = stEstructura.IndexOf(System.Environment.NewLine);
            }

            iLargoMax = Math.Max(iLargoMax, 20);
            iLargoMax += 2;
            oSalida.Clear();
            foreach (var elemSalida in clcTamano)
            {
                oSalida.Append(elemSalida.Nombre.PadRight(iLargoMax, ' '));
                oSalida.Append("[");
                oSalida.Append(elemSalida.Tamano.ToString().PadLeft(3, ' '));
                oSalida.Append("]");
                oSalida.Append(" ; ");
                oSalida.Append(elemSalida.PosIni.ToString().PadLeft(4, ' '));
                oSalida.Append(" ; ");
                oSalida.Append(elemSalida.PosFin.ToString().PadLeft(4, ' '));
                oSalida.Append(System.Environment.NewLine);
            }

            sSalida = oSalida.ToString();
        }
    }
}
