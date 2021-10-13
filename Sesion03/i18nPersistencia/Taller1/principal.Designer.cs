namespace Taller1
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlOperadores = new System.Windows.Forms.Panel();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.pnlNumeros = new System.Windows.Forms.Panel();
            this.btnCambioSigno = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlOperadores.SuspendLayout();
            this.pnlNumeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuAyuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(551, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig,
            this.toolStripSeparator1,
            this.menuSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(150, 22);
            this.menuConfig.Text = "Configuración";
            this.menuConfig.Click += new System.EventHandler(this.menuConfig_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(150, 22);
            this.menuSalir.Text = "&Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcercaDe});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "A&yuda";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Teal;
            this.pnlDisplay.Controls.Add(this.statusStrip);
            this.pnlDisplay.Controls.Add(this.pnlOperadores);
            this.pnlDisplay.Controls.Add(this.pnlNumeros);
            this.pnlDisplay.Controls.Add(this.lblDisplay);
            this.pnlDisplay.Location = new System.Drawing.Point(0, 27);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(580, 574);
            this.pnlDisplay.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 552);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(580, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlOperadores
            // 
            this.pnlOperadores.BackColor = System.Drawing.Color.MintCream;
            this.pnlOperadores.Controls.Add(this.btnRaiz);
            this.pnlOperadores.Controls.Add(this.btnPotencia);
            this.pnlOperadores.Controls.Add(this.btnDivide);
            this.pnlOperadores.Controls.Add(this.btnMultiplica);
            this.pnlOperadores.Controls.Add(this.btnBorra);
            this.pnlOperadores.Controls.Add(this.btnResta);
            this.pnlOperadores.Controls.Add(this.btnCalcula);
            this.pnlOperadores.Controls.Add(this.btnSuma);
            this.pnlOperadores.Location = new System.Drawing.Point(337, 121);
            this.pnlOperadores.Name = "pnlOperadores";
            this.pnlOperadores.Size = new System.Drawing.Size(202, 383);
            this.pnlOperadores.TabIndex = 2;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(106, 101);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 74);
            this.btnRaiz.TabIndex = 11;
            this.btnRaiz.Text = "r";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(106, 21);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 74);
            this.btnPotencia.TabIndex = 10;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(25, 261);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 74);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.Location = new System.Drawing.Point(25, 181);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(75, 74);
            this.btnMultiplica.TabIndex = 6;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorra.Location = new System.Drawing.Point(106, 181);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(75, 74);
            this.btnBorra.TabIndex = 4;
            this.btnBorra.Text = "B";
            this.btnBorra.UseVisualStyleBackColor = true;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(25, 101);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 74);
            this.btnResta.TabIndex = 3;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(106, 261);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 74);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "=";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(25, 21);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 74);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Tag = "operador";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // pnlNumeros
            // 
            this.pnlNumeros.BackColor = System.Drawing.Color.MintCream;
            this.pnlNumeros.Controls.Add(this.btnCambioSigno);
            this.pnlNumeros.Controls.Add(this.btn0);
            this.pnlNumeros.Controls.Add(this.btnComa);
            this.pnlNumeros.Controls.Add(this.btn9);
            this.pnlNumeros.Controls.Add(this.btn8);
            this.pnlNumeros.Controls.Add(this.btn7);
            this.pnlNumeros.Controls.Add(this.btn6);
            this.pnlNumeros.Controls.Add(this.btn5);
            this.pnlNumeros.Controls.Add(this.btn4);
            this.pnlNumeros.Controls.Add(this.btn3);
            this.pnlNumeros.Controls.Add(this.btn2);
            this.pnlNumeros.Controls.Add(this.btn1);
            this.pnlNumeros.Location = new System.Drawing.Point(23, 121);
            this.pnlNumeros.Name = "pnlNumeros";
            this.pnlNumeros.Size = new System.Drawing.Size(287, 383);
            this.pnlNumeros.TabIndex = 1;
            // 
            // btnCambioSigno
            // 
            this.btnCambioSigno.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioSigno.Location = new System.Drawing.Point(187, 261);
            this.btnCambioSigno.Name = "btnCambioSigno";
            this.btnCambioSigno.Size = new System.Drawing.Size(75, 74);
            this.btnCambioSigno.TabIndex = 11;
            this.btnCambioSigno.Tag = "numeros";
            this.btnCambioSigno.Text = "-";
            this.btnCambioSigno.UseVisualStyleBackColor = true;
            this.btnCambioSigno.Click += new System.EventHandler(this.btnCambioSigno_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(106, 261);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 74);
            this.btn0.TabIndex = 10;
            this.btn0.Tag = "numeros";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btnComa
            // 
            this.btnComa.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(25, 261);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(75, 74);
            this.btnComa.TabIndex = 9;
            this.btnComa.Tag = "numeros";
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(187, 181);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 74);
            this.btn9.TabIndex = 8;
            this.btn9.Tag = "numeros";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(106, 181);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 74);
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "numeros";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(25, 181);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 74);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "numeros";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(187, 101);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 74);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "numeros";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(106, 101);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 74);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "numeros";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(25, 101);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 74);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "numeros";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(187, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 74);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "numeros";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(106, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 74);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "numeros";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(25, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 74);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "numeros";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumerosClick);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisplay.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(14, 37);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(515, 65);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Principal
            // 
            this.AccessibleDescription = "tex";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 561);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlOperadores.ResumeLayout(false);
            this.pnlNumeros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel pnlNumeros;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel pnlOperadores;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnBorra;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnCambioSigno;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

