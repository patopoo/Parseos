using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parseos_Net
{
    public partial class frmParseos : Form
    {
        public frmParseos()
        {
            InitializeComponent();
        }

        private void btnParsear_Click(object sender, EventArgs e)
        {
            String sSalida;
            Utiles uu = new Utiles();
            int iLargoTotal;

            uu.parseo(rbSi.Checked, rbLenguajeVB.Checked, rbLenguajeC.Checked, rbLenguajeSubstring.Checked,
                        txtNroElem.Text, txtEstructura.Text, txtData.Text,
                        txtLargoNumerico.Text, txtLargoCupoDolar.Text,
                        out sSalida, out iLargoTotal);
            if (chkMultiline.Checked)
            {
                txtSalida.Text = sSalida;
                txtSalida2.Text = "";
            }
            else
            {
                txtSalida.Text = "";
                txtSalida2.Text = sSalida;
            }
            txtLargoTotal.Text = iLargoTotal.ToString();
        }

        private void btnLimpiaData_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void chkMultiline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultiline.Checked)
            {
                txtSalida.Visible = true;
                txtSalida2.Visible = false;
            }
            else
            {
                txtSalida.Visible = false;
                txtSalida2.Visible = true;
            }
        }

        private void btnLimpiaEstructura_Click(object sender, EventArgs e)
        {
            txtEstructura.Clear();
        }

        private void txtEstructura_Enter(object sender, EventArgs e)
        {
            txtEstructura.Select(0, txtEstructura.TextLength);
        }

        private void btnLimpiaSalida_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiaData_Click(sender, e);
            btnLimpiaSalida_Click(sender, e);
            btnLimpiaEstructura_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEstructura_Leave(object sender, EventArgs e)
        {
            String sTexto;
            StringBuilder sRetu = new StringBuilder();
            String sLinea;
            int k, i = 0;

            sTexto = txtEstructura.Text;
            sTexto.Replace(" ;", ";");
            if (sTexto.IndexOf("] ;") > 0)
            {
                int r = sTexto.IndexOf("] ;");
                sTexto.Replace(" ;", ";");
                sTexto.Replace(" ;", ";");
                sTexto.Replace(" ;", ";");
            }
            if (sTexto.IndexOf("];") > 0)
            {
                rbLenguajeC.Checked = true;
            }
            else
            {
                if (sTexto.IndexOf("*") > 0)
                {
                    rbLenguajeVB.Checked = true;
                }
                else
                {
                    if (sTexto.ToUpper().IndexOf("SUBSTRING") > 0)
                    {
                        rbLenguajeSubstring.Checked = true;
                    }
                    else
                    {
                        rbLenguajeC.Checked = true;
                    }
                }
            }

            sTexto += System.Environment.NewLine;
            sRetu.Clear();
            k = sTexto.IndexOf(System.Environment.NewLine);
            while (k > 0)
            {
                sLinea = sTexto.Substring(i, k).Replace("\t", " ").Trim();
                sRetu.Append(sLinea);
                sRetu.Append(System.Environment.NewLine);
                sTexto = sTexto.Remove(0, k + 2);
                k = sTexto.IndexOf(System.Environment.NewLine);
            }
            if (sRetu.Length > 0)
            {
                txtEstructura.Text = sRetu.ToString();
            }
        }

        private void rbLenguajeVB_CheckedChanged(object sender, EventArgs e)
        {
            HabDesLargoNumerico();
        }

        private void rbLenguajeC_CheckedChanged(object sender, EventArgs e)
        {
            HabDesLargoNumerico();
        }

        private void rbLenguajeSubstring_CheckedChanged(object sender, EventArgs e)
        {
            HabDesLargoNumerico();
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            HabDesNroElem();
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            HabDesNroElem();
        }

        private void HabDesNroElem()
        {
            if (rbSi.Checked)
            {
                lblNroElem.Enabled = true;
                txtNroElem.Enabled = true;
                lblNroElem.Visible = true;
                txtNroElem.Visible = true;
            }

            if (rbNo.Checked)
            {
                lblNroElem.Enabled = false;
                txtNroElem.Enabled = false;
                lblNroElem.Visible = false;
                txtNroElem.Visible = false;
            }
        }

        private void HabDesLargoNumerico()
        {
            if (rbLenguajeVB.Checked)
            {
                lblLargoNumerico.Visible = true;
                lblLargoCupoDolar.Visible = true;
                txtLargoNumerico.Visible = true;
                txtLargoCupoDolar.Visible = true;
            }

            if (rbLenguajeC.Checked)
            {
                lblLargoNumerico.Visible = false;
                lblLargoCupoDolar.Visible = false;
                txtLargoNumerico.Visible = false;
                txtLargoCupoDolar.Visible = false;
            }

            if (rbLenguajeSubstring.Checked)
            {
                lblLargoNumerico.Visible = false;
                lblLargoCupoDolar.Visible = false;
                txtLargoNumerico.Visible = false;
                txtLargoCupoDolar.Visible = false;
            }
        }

        private void btnTamanos_Click(object sender, EventArgs e)
        {
            String sSalida;
            Utiles uu = new Utiles();

            uu.Tamanos(txtEstructura.Text, rbLenguajeVB.Checked, rbLenguajeC.Checked, rbLenguajeSubstring.Checked, txtLargoNumerico.Text, txtLargoCupoDolar.Text,
                        out sSalida);
            if (chkMultiline.Checked)
            {
                txtSalida.Text = sSalida;
                txtSalida2.Text = "";
            }
            else
            {
                txtSalida.Text = "";
                txtSalida2.Text = sSalida;
            }
        }

        private void frmParseos_Load(object sender, EventArgs e)
        {
            //FontFamily ffam = new FontFamily("Courier New");
            FontFamily ffam = new FontFamily("Consolas");
            txtEstructura.Font = new Font(ffam, 8);
            txtSalida.Font = new Font(ffam, 8);
            txtEstructura.ScrollBars = ScrollBars.Both;
            txtSalida.ScrollBars = ScrollBars.Both;
            txtEstructura.WordWrap = false;
            txtSalida.WordWrap = false;
            txtData.MaxLength = 0;

            rbNo.Checked = true;
            chkMultiline.Checked = true;

            Rectangle workArea = Screen.GetWorkingArea(this);

            this.Size = new Size(workArea.Width - (workArea.Width / 5), workArea.Height - (workArea.Height / 5));
            //frmParseos_Resize(null, null);
            rbLenguajeC.Checked = true;
            this.CenterToScreen();
            frmParseos_Resize(this, e);
        }

        private void frmParseos_Resize(object sender, EventArgs e)
        {
            int iAnchoPanel = 0;
            int iMargenTop = 8; // 120;
            int iDistLabel = 10; // 150;
            int iDistSuperior = 10; // 80;
            int iMargenIzq = 8; // 200;
            int iMargenInf = 50; // 600;
            //int iMargenDer = 8; // 300;
            int ifiller_alto = 150;
            int ifiller_ancho = 30;
            int ancho_central;

            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            { return; }

            /*
            if (this.Size.Height < 540 || this.Size.Width < 550)
            {
                return;
            }
            */
            if (this.Size.Height < 540)
            {
                this.Size = new Size(this.Size.Width, 540);
            }
            if (this.Size.Width < 550)
            {
                this.Size = new Size(550, this.Size.Height);
            }

            ancho_central = Math.Max(Math.Max(gbArray.Width, gbLenguaje.Width), btnTamanos.Width);

            lblDataParsear.Left = iMargenIzq;
            txtData.Left = lblDataParsear.Left + lblDataParsear.Width + iMargenIzq;

            txtEstructura.Height = this.Size.Height - ifiller_alto;
            txtSalida.Height = this.Size.Height - ifiller_alto;
            iAnchoPanel = (this.Size.Width / 2) - gbLenguaje.Width - ifiller_ancho;
            txtData.Width = this.Size.Width - txtData.Left - Math.Max(lblLargoNumerico.Width, lblLargoCupoDolar.Width) - Math.Max(txtLargoNumerico.Width, txtLargoCupoDolar.Width) - (iMargenIzq * 4);
            btnLimpiaData.Left = txtData.Left + txtData.Width - btnLimpiaData.Width;

            lblLargoNumerico.Left = txtData.Left + txtData.Width + iMargenIzq;
            lblLargoCupoDolar.Left = lblLargoNumerico.Left;
            txtLargoNumerico.Left = lblLargoNumerico.Left + Math.Max(lblLargoNumerico.Width, lblLargoCupoDolar.Width) + (iMargenIzq / 2);
            txtLargoCupoDolar.Left = txtLargoNumerico.Left;

            txtEstructura.Left = iMargenIzq;
            lblEstructura.Left = txtEstructura.Left;
            txtSalida.Width = iAnchoPanel;
            txtEstructura.Width = iAnchoPanel;
            gbLenguaje.Left = txtEstructura.Left + txtEstructura.Width + iMargenIzq;

            gbLenguaje.Width = ancho_central;
            gbArray.Left = txtEstructura.Left + txtEstructura.Width + iMargenIzq;
            gbArray.Width = ancho_central;
            btnParsear.Left = txtEstructura.Left + txtEstructura.Width + iMargenIzq;
            btnParsear.Width = ancho_central;
            btnTamanos.Left = btnParsear.Left;
            btnTamanos.Width = ancho_central;
            btnLimpiar.Left = btnParsear.Left;
            btnLimpiar.Width = ancho_central;
            btnSalir.Left = btnParsear.Left;
            btnSalir.Width = ancho_central;
            txtSalida.Left = Math.Max(gbArray.Left + gbArray.Width, gbLenguaje.Left + gbLenguaje.Width) + iMargenIzq;
            lblSalida.Left = txtSalida.Left;
            btnLimpiaEstructura.Left = txtEstructura.Left + txtEstructura.Width - btnLimpiaEstructura.Width;
            btnCopiarSalida.Left = txtSalida.Left + txtSalida.Width + iMargenIzq;
            btnLimpiaSalida.Left = btnCopiarSalida.Left;
            txtLargoTotal.Left = txtSalida.Left + txtSalida.Width + iMargenIzq;
            lblLargoTotal.Left = txtLargoTotal.Left - lblLargoTotal.Width - iDistLabel;

            txtData.Top = iMargenTop;
            lblDataParsear.Top = txtData.Top;
            txtLargoNumerico.Top = txtData.Top;
            lblLargoNumerico.Top = txtLargoNumerico.Top + txtLargoNumerico.Height - lblLargoNumerico.Height - iDistSuperior;
            txtLargoCupoDolar.Top = txtLargoNumerico.Top + txtLargoNumerico.Height + iDistSuperior;
            lblLargoCupoDolar.Top = txtLargoCupoDolar.Top + txtLargoCupoDolar.Height - lblLargoCupoDolar.Height - iDistSuperior;
            btnLimpiaData.Top = txtLargoCupoDolar.Top;
            lblEstructura.Top = txtData.Top + txtData.Height + Math.Max(btnLimpiaData.Height, txtLargoCupoDolar.Height) - iDistSuperior;
            lblSalida.Top = lblEstructura.Top;

            txtEstructura.Top = btnLimpiaData.Top + Math.Max(btnLimpiaData.Height, txtLargoCupoDolar.Height) + iDistSuperior;
            txtSalida.Top = txtEstructura.Top;
            gbLenguaje.Top = lblSalida.Top;
            gbArray.Top = gbLenguaje.Top + gbLenguaje.Height + iDistSuperior;
            btnParsear.Top = gbArray.Top + gbArray.Height + iDistSuperior;
            btnTamanos.Top = btnParsear.Top + btnParsear.Height + iDistSuperior;

            btnLimpiaEstructura.Top = txtEstructura.Top + txtEstructura.Height + iDistSuperior;
            txtLargoTotal.Top = this.Size.Height - txtLargoTotal.Height - iMargenInf;
            lblLargoTotal.Top = txtLargoTotal.Top + lblLargoTotal.Height - iDistSuperior;
            btnLimpiaSalida.Top = txtLargoTotal.Top - btnLimpiaSalida.Height - iDistSuperior;
            btnCopiarSalida.Top = btnLimpiaSalida.Top - btnCopiarSalida.Height - iDistSuperior;
            btnSalir.Top = txtEstructura.Top + txtEstructura.Height - btnSalir.Height;
            btnLimpiar.Top = btnSalir.Top - btnLimpiar.Height - iDistSuperior;

            chkMultiline.Top = btnCopiarSalida.Top - chkMultiline.Height - iDistSuperior;
            chkMultiline.Left = btnCopiarSalida.Left;

            txtSalida2.Top = txtSalida.Top;
            txtSalida2.Left = txtSalida.Left;
            txtSalida2.Width = txtSalida.Width;
            txtSalida2.Height = txtData.Height;
        }

        private void btnCopiarSalida_Click(object sender, EventArgs e)
        {
            if (chkMultiline.Checked)
                Clipboard.SetText(txtSalida.Text);
            else
                Clipboard.SetText(txtSalida2.Text);
        }

        private void txtEstructura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
