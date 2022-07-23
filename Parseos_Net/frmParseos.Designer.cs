namespace Parseos_Net
{
    partial class frmParseos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParseos));
            this.lblDataParsear = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnLimpiaData = new System.Windows.Forms.Button();
            this.gbLenguaje = new System.Windows.Forms.GroupBox();
            this.rbLenguajeSubstring = new System.Windows.Forms.RadioButton();
            this.rbLenguajeC = new System.Windows.Forms.RadioButton();
            this.rbLenguajeVB = new System.Windows.Forms.RadioButton();
            this.chkMultiline = new System.Windows.Forms.CheckBox();
            this.lblEstructura = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtEstructura = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.gbArray = new System.Windows.Forms.GroupBox();
            this.txtNroElem = new System.Windows.Forms.TextBox();
            this.lblNroElem = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.btnLimpiaEstructura = new System.Windows.Forms.Button();
            this.btnLimpiaSalida = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnParsear = new System.Windows.Forms.Button();
            this.btnTamanos = new System.Windows.Forms.Button();
            this.lblLargoTotal = new System.Windows.Forms.Label();
            this.txtLargoTotal = new System.Windows.Forms.TextBox();
            this.btnCopiarSalida = new System.Windows.Forms.Button();
            this.txtSalida2 = new System.Windows.Forms.TextBox();
            this.lblLargoNumerico = new System.Windows.Forms.Label();
            this.txtLargoNumerico = new System.Windows.Forms.TextBox();
            this.lblLargoCupoDolar = new System.Windows.Forms.Label();
            this.txtLargoCupoDolar = new System.Windows.Forms.TextBox();
            this.gbLenguaje.SuspendLayout();
            this.gbArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataParsear
            // 
            this.lblDataParsear.AutoSize = true;
            this.lblDataParsear.Location = new System.Drawing.Point(8, 13);
            this.lblDataParsear.Name = "lblDataParsear";
            this.lblDataParsear.Size = new System.Drawing.Size(78, 13);
            this.lblDataParsear.TabIndex = 0;
            this.lblDataParsear.Text = "Data a Parsear";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(92, 10);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(616, 20);
            this.txtData.TabIndex = 1;
            // 
            // btnLimpiaData
            // 
            this.btnLimpiaData.Location = new System.Drawing.Point(662, 36);
            this.btnLimpiaData.Name = "btnLimpiaData";
            this.btnLimpiaData.Size = new System.Drawing.Size(35, 23);
            this.btnLimpiaData.TabIndex = 2;
            this.btnLimpiaData.Text = "[   ]";
            this.btnLimpiaData.UseVisualStyleBackColor = true;
            this.btnLimpiaData.Click += new System.EventHandler(this.btnLimpiaData_Click);
            // 
            // gbLenguaje
            // 
            this.gbLenguaje.Controls.Add(this.rbLenguajeSubstring);
            this.gbLenguaje.Controls.Add(this.rbLenguajeC);
            this.gbLenguaje.Controls.Add(this.rbLenguajeVB);
            this.gbLenguaje.Location = new System.Drawing.Point(306, 62);
            this.gbLenguaje.Name = "gbLenguaje";
            this.gbLenguaje.Size = new System.Drawing.Size(68, 99);
            this.gbLenguaje.TabIndex = 3;
            this.gbLenguaje.TabStop = false;
            this.gbLenguaje.Text = "Lenguaje";
            // 
            // rbLenguajeSubstring
            // 
            this.rbLenguajeSubstring.AutoSize = true;
            this.rbLenguajeSubstring.Location = new System.Drawing.Point(8, 70);
            this.rbLenguajeSubstring.Name = "rbLenguajeSubstring";
            this.rbLenguajeSubstring.Size = new System.Drawing.Size(67, 17);
            this.rbLenguajeSubstring.TabIndex = 2;
            this.rbLenguajeSubstring.TabStop = true;
            this.rbLenguajeSubstring.Text = "substring";
            this.rbLenguajeSubstring.UseVisualStyleBackColor = true;
            this.rbLenguajeSubstring.CheckedChanged += new System.EventHandler(this.rbLenguajeSubstring_CheckedChanged);
            // 
            // rbLenguajeC
            // 
            this.rbLenguajeC.AutoSize = true;
            this.rbLenguajeC.Location = new System.Drawing.Point(8, 47);
            this.rbLenguajeC.Name = "rbLenguajeC";
            this.rbLenguajeC.Size = new System.Drawing.Size(32, 17);
            this.rbLenguajeC.TabIndex = 1;
            this.rbLenguajeC.TabStop = true;
            this.rbLenguajeC.Text = "C";
            this.rbLenguajeC.UseVisualStyleBackColor = true;
            this.rbLenguajeC.CheckedChanged += new System.EventHandler(this.rbLenguajeC_CheckedChanged);
            // 
            // rbLenguajeVB
            // 
            this.rbLenguajeVB.AutoSize = true;
            this.rbLenguajeVB.Location = new System.Drawing.Point(8, 24);
            this.rbLenguajeVB.Name = "rbLenguajeVB";
            this.rbLenguajeVB.Size = new System.Drawing.Size(39, 17);
            this.rbLenguajeVB.TabIndex = 0;
            this.rbLenguajeVB.TabStop = true;
            this.rbLenguajeVB.Text = "VB";
            this.rbLenguajeVB.UseVisualStyleBackColor = true;
            this.rbLenguajeVB.CheckedChanged += new System.EventHandler(this.rbLenguajeVB_CheckedChanged);
            // 
            // chkMultiline
            // 
            this.chkMultiline.AutoSize = true;
            this.chkMultiline.Location = new System.Drawing.Point(706, 159);
            this.chkMultiline.Name = "chkMultiline";
            this.chkMultiline.Size = new System.Drawing.Size(64, 17);
            this.chkMultiline.TabIndex = 4;
            this.chkMultiline.Text = "Multiline";
            this.chkMultiline.UseVisualStyleBackColor = true;
            this.chkMultiline.CheckedChanged += new System.EventHandler(this.chkMultiline_CheckedChanged);
            // 
            // lblEstructura
            // 
            this.lblEstructura.AutoSize = true;
            this.lblEstructura.Location = new System.Drawing.Point(8, 41);
            this.lblEstructura.Name = "lblEstructura";
            this.lblEstructura.Size = new System.Drawing.Size(55, 13);
            this.lblEstructura.TabIndex = 5;
            this.lblEstructura.Text = "Estructura";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(405, 41);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 6;
            this.lblSalida.Text = "Salida";
            // 
            // txtEstructura
            // 
            this.txtEstructura.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstructura.Location = new System.Drawing.Point(12, 57);
            this.txtEstructura.MaxLength = 0;
            this.txtEstructura.Multiline = true;
            this.txtEstructura.Name = "txtEstructura";
            this.txtEstructura.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEstructura.Size = new System.Drawing.Size(265, 177);
            this.txtEstructura.TabIndex = 7;
            this.txtEstructura.WordWrap = false;
            this.txtEstructura.TextChanged += new System.EventHandler(this.txtEstructura_TextChanged);
            this.txtEstructura.Enter += new System.EventHandler(this.txtEstructura_Enter);
            this.txtEstructura.Leave += new System.EventHandler(this.txtEstructura_Leave);
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(408, 62);
            this.txtSalida.MaxLength = 0;
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(265, 177);
            this.txtSalida.TabIndex = 8;
            this.txtSalida.WordWrap = false;
            // 
            // gbArray
            // 
            this.gbArray.Controls.Add(this.txtNroElem);
            this.gbArray.Controls.Add(this.lblNroElem);
            this.gbArray.Controls.Add(this.rbNo);
            this.gbArray.Controls.Add(this.rbSi);
            this.gbArray.Location = new System.Drawing.Point(306, 179);
            this.gbArray.Name = "gbArray";
            this.gbArray.Size = new System.Drawing.Size(68, 111);
            this.gbArray.TabIndex = 4;
            this.gbArray.TabStop = false;
            this.gbArray.Text = "Array";
            // 
            // txtNroElem
            // 
            this.txtNroElem.Location = new System.Drawing.Point(8, 85);
            this.txtNroElem.Name = "txtNroElem";
            this.txtNroElem.Size = new System.Drawing.Size(39, 20);
            this.txtNroElem.TabIndex = 8;
            // 
            // lblNroElem
            // 
            this.lblNroElem.AutoSize = true;
            this.lblNroElem.Location = new System.Drawing.Point(5, 67);
            this.lblNroElem.Name = "lblNroElem";
            this.lblNroElem.Size = new System.Drawing.Size(39, 13);
            this.lblNroElem.TabIndex = 7;
            this.lblNroElem.Text = "# elem";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(8, 47);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(8, 24);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // btnLimpiaEstructura
            // 
            this.btnLimpiaEstructura.Location = new System.Drawing.Point(242, 245);
            this.btnLimpiaEstructura.Name = "btnLimpiaEstructura";
            this.btnLimpiaEstructura.Size = new System.Drawing.Size(35, 23);
            this.btnLimpiaEstructura.TabIndex = 9;
            this.btnLimpiaEstructura.Text = "[   ]";
            this.btnLimpiaEstructura.UseVisualStyleBackColor = true;
            this.btnLimpiaEstructura.Click += new System.EventHandler(this.btnLimpiaEstructura_Click);
            // 
            // btnLimpiaSalida
            // 
            this.btnLimpiaSalida.Location = new System.Drawing.Point(638, 245);
            this.btnLimpiaSalida.Name = "btnLimpiaSalida";
            this.btnLimpiaSalida.Size = new System.Drawing.Size(35, 23);
            this.btnLimpiaSalida.TabIndex = 10;
            this.btnLimpiaSalida.Text = "[   ]";
            this.btnLimpiaSalida.UseVisualStyleBackColor = true;
            this.btnLimpiaSalida.Click += new System.EventHandler(this.btnLimpiaSalida_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(147, 284);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 30);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(147, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnParsear
            // 
            this.btnParsear.Location = new System.Drawing.Point(306, 302);
            this.btnParsear.Name = "btnParsear";
            this.btnParsear.Size = new System.Drawing.Size(74, 66);
            this.btnParsear.TabIndex = 13;
            this.btnParsear.Text = "&Parsear";
            this.btnParsear.UseVisualStyleBackColor = true;
            this.btnParsear.Click += new System.EventHandler(this.btnParsear_Click);
            // 
            // btnTamanos
            // 
            this.btnTamanos.Location = new System.Drawing.Point(408, 254);
            this.btnTamanos.Name = "btnTamanos";
            this.btnTamanos.Size = new System.Drawing.Size(74, 30);
            this.btnTamanos.TabIndex = 14;
            this.btnTamanos.Text = "&Tamaños";
            this.btnTamanos.UseVisualStyleBackColor = true;
            this.btnTamanos.Click += new System.EventHandler(this.btnTamanos_Click);
            // 
            // lblLargoTotal
            // 
            this.lblLargoTotal.AutoSize = true;
            this.lblLargoTotal.Location = new System.Drawing.Point(519, 333);
            this.lblLargoTotal.Name = "lblLargoTotal";
            this.lblLargoTotal.Size = new System.Drawing.Size(61, 13);
            this.lblLargoTotal.TabIndex = 16;
            this.lblLargoTotal.Text = "Largo Total";
            // 
            // txtLargoTotal
            // 
            this.txtLargoTotal.Location = new System.Drawing.Point(589, 330);
            this.txtLargoTotal.Name = "txtLargoTotal";
            this.txtLargoTotal.Size = new System.Drawing.Size(58, 20);
            this.txtLargoTotal.TabIndex = 15;
            this.txtLargoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCopiarSalida
            // 
            this.btnCopiarSalida.Location = new System.Drawing.Point(679, 203);
            this.btnCopiarSalida.Name = "btnCopiarSalida";
            this.btnCopiarSalida.Size = new System.Drawing.Size(74, 40);
            this.btnCopiarSalida.TabIndex = 17;
            this.btnCopiarSalida.Text = "&Copiar Salida";
            this.btnCopiarSalida.UseVisualStyleBackColor = true;
            this.btnCopiarSalida.Click += new System.EventHandler(this.btnCopiarSalida_Click);
            // 
            // txtSalida2
            // 
            this.txtSalida2.Location = new System.Drawing.Point(679, 65);
            this.txtSalida2.Name = "txtSalida2";
            this.txtSalida2.Size = new System.Drawing.Size(84, 20);
            this.txtSalida2.TabIndex = 18;
            // 
            // lblLargoNumerico
            // 
            this.lblLargoNumerico.AutoSize = true;
            this.lblLargoNumerico.Location = new System.Drawing.Point(772, 17);
            this.lblLargoNumerico.Name = "lblLargoNumerico";
            this.lblLargoNumerico.Size = new System.Drawing.Size(82, 13);
            this.lblLargoNumerico.TabIndex = 20;
            this.lblLargoNumerico.Text = "Largo Numerico";
            // 
            // txtLargoNumerico
            // 
            this.txtLargoNumerico.Location = new System.Drawing.Point(868, 13);
            this.txtLargoNumerico.Name = "txtLargoNumerico";
            this.txtLargoNumerico.Size = new System.Drawing.Size(32, 20);
            this.txtLargoNumerico.TabIndex = 19;
            this.txtLargoNumerico.Text = "12";
            this.txtLargoNumerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLargoCupoDolar
            // 
            this.lblLargoCupoDolar.AutoSize = true;
            this.lblLargoCupoDolar.Location = new System.Drawing.Point(772, 49);
            this.lblLargoCupoDolar.Name = "lblLargoCupoDolar";
            this.lblLargoCupoDolar.Size = new System.Drawing.Size(90, 13);
            this.lblLargoCupoDolar.TabIndex = 22;
            this.lblLargoCupoDolar.Text = "Largo Cupo Dolar";
            // 
            // txtLargoCupoDolar
            // 
            this.txtLargoCupoDolar.Location = new System.Drawing.Point(868, 46);
            this.txtLargoCupoDolar.Name = "txtLargoCupoDolar";
            this.txtLargoCupoDolar.Size = new System.Drawing.Size(32, 20);
            this.txtLargoCupoDolar.TabIndex = 21;
            this.txtLargoCupoDolar.Text = "14";
            this.txtLargoCupoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmParseos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 404);
            this.Controls.Add(this.lblLargoCupoDolar);
            this.Controls.Add(this.txtLargoCupoDolar);
            this.Controls.Add(this.lblLargoNumerico);
            this.Controls.Add(this.txtLargoNumerico);
            this.Controls.Add(this.txtSalida2);
            this.Controls.Add(this.btnCopiarSalida);
            this.Controls.Add(this.lblLargoTotal);
            this.Controls.Add(this.txtLargoTotal);
            this.Controls.Add(this.btnTamanos);
            this.Controls.Add(this.btnParsear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLimpiaSalida);
            this.Controls.Add(this.btnLimpiaEstructura);
            this.Controls.Add(this.gbArray);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEstructura);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEstructura);
            this.Controls.Add(this.chkMultiline);
            this.Controls.Add(this.gbLenguaje);
            this.Controls.Add(this.btnLimpiaData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblDataParsear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParseos";
            this.Text = "Parseos 2.0";
            this.Load += new System.EventHandler(this.frmParseos_Load);
            this.Resize += new System.EventHandler(this.frmParseos_Resize);
            this.gbLenguaje.ResumeLayout(false);
            this.gbLenguaje.PerformLayout();
            this.gbArray.ResumeLayout(false);
            this.gbArray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataParsear;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnLimpiaData;
        private System.Windows.Forms.GroupBox gbLenguaje;
        private System.Windows.Forms.CheckBox chkMultiline;
        private System.Windows.Forms.Label lblEstructura;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtEstructura;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.RadioButton rbLenguajeC;
        private System.Windows.Forms.RadioButton rbLenguajeVB;
        private System.Windows.Forms.GroupBox gbArray;
        private System.Windows.Forms.TextBox txtNroElem;
        private System.Windows.Forms.Label lblNroElem;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Button btnLimpiaEstructura;
        private System.Windows.Forms.Button btnLimpiaSalida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnParsear;
        private System.Windows.Forms.Button btnTamanos;
        private System.Windows.Forms.Label lblLargoTotal;
        private System.Windows.Forms.TextBox txtLargoTotal;
        private System.Windows.Forms.Button btnCopiarSalida;
        private System.Windows.Forms.TextBox txtSalida2;
        private System.Windows.Forms.Label lblLargoNumerico;
        private System.Windows.Forms.TextBox txtLargoNumerico;
        private System.Windows.Forms.Label lblLargoCupoDolar;
        private System.Windows.Forms.TextBox txtLargoCupoDolar;
        private System.Windows.Forms.RadioButton rbLenguajeSubstring;
    }
}

