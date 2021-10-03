
namespace Prueba
{
    partial class form1
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pnlNumeros = new System.Windows.Forms.Panel();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.pnlOperadores = new System.Windows.Forms.Panel();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.signo = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.opActual = new System.Windows.Forms.Label();
            this.pnlNumeros.SuspendLayout();
            this.pnlOperadores.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDisplay.Location = new System.Drawing.Point(8, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(519, 64);
            this.lblDisplay.TabIndex = 230;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlNumeros
            // 
            this.pnlNumeros.Controls.Add(this.btnComa);
            this.pnlNumeros.Controls.Add(this.btn5);
            this.pnlNumeros.Controls.Add(this.btn1);
            this.pnlNumeros.Controls.Add(this.btn2);
            this.pnlNumeros.Controls.Add(this.btn9);
            this.pnlNumeros.Controls.Add(this.btn8);
            this.pnlNumeros.Controls.Add(this.btn0);
            this.pnlNumeros.Controls.Add(this.btn7);
            this.pnlNumeros.Controls.Add(this.btn6);
            this.pnlNumeros.Controls.Add(this.btn3);
            this.pnlNumeros.Controls.Add(this.btn4);
            this.pnlNumeros.Location = new System.Drawing.Point(12, 67);
            this.pnlNumeros.Name = "pnlNumeros";
            this.pnlNumeros.Size = new System.Drawing.Size(247, 239);
            this.pnlNumeros.TabIndex = 24;
            // 
            // btnComa
            // 
            this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(26, 184);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(63, 47);
            this.btnComa.TabIndex = 15;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(95, 77);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 45);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click_1);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(26, 26);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(95, 26);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(164, 128);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 47);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click_1);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(95, 128);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 47);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click_1);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(95, 184);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(132, 47);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click_1);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(26, 128);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 47);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click_1);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(164, 77);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 45);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click_1);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(164, 26);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(26, 77);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 45);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click_1);
            // 
            // pnlOperadores
            // 
            this.pnlOperadores.Controls.Add(this.btnRaiz);
            this.pnlOperadores.Controls.Add(this.btnPotencia);
            this.pnlOperadores.Controls.Add(this.btnSuma);
            this.pnlOperadores.Controls.Add(this.btnMultiplica);
            this.pnlOperadores.Controls.Add(this.btnResta);
            this.pnlOperadores.Controls.Add(this.btnDivide);
            this.pnlOperadores.Location = new System.Drawing.Point(265, 67);
            this.pnlOperadores.Name = "pnlOperadores";
            this.pnlOperadores.Size = new System.Drawing.Size(156, 189);
            this.pnlOperadores.TabIndex = 25;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(7, 26);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(63, 45);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.Location = new System.Drawing.Point(7, 128);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(63, 47);
            this.btnMultiplica.TabIndex = 3;
            this.btnMultiplica.Text = "X";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(7, 77);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(63, 45);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(76, 25);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(63, 47);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.signo);
            this.pnlAcciones.Controls.Add(this.btnResult);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Location = new System.Drawing.Point(443, 67);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(71, 189);
            this.pnlAcciones.TabIndex = 26;
            // 
            // signo
            // 
            this.signo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signo.Location = new System.Drawing.Point(4, 128);
            this.signo.Name = "signo";
            this.signo.Size = new System.Drawing.Size(63, 45);
            this.signo.TabIndex = 18;
            this.signo.Text = "+ / -";
            this.signo.UseVisualStyleBackColor = true;
            this.signo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(4, 26);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(63, 45);
            this.btnResult.TabIndex = 16;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(3, 77);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 45);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "B";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDisplay.Controls.Add(this.opActual);
            this.pnlDisplay.Controls.Add(this.pnlAcciones);
            this.pnlDisplay.Controls.Add(this.pnlOperadores);
            this.pnlDisplay.Controls.Add(this.pnlNumeros);
            this.pnlDisplay.Controls.Add(this.lblDisplay);
            this.pnlDisplay.Location = new System.Drawing.Point(0, -2);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(527, 314);
            this.pnlDisplay.TabIndex = 23;
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(76, 78);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(63, 47);
            this.btnPotencia.TabIndex = 16;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(76, 127);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(63, 47);
            this.btnRaiz.TabIndex = 17;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.button2_Click);
            // 
            // opActual
            // 
            this.opActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opActual.Location = new System.Drawing.Point(272, 263);
            this.opActual.Name = "opActual";
            this.opActual.Size = new System.Drawing.Size(242, 43);
            this.opActual.TabIndex = 231;
            this.opActual.Text = "label1";
            this.opActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opActual.Click += new System.EventHandler(this.opActual_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 310);
            this.Controls.Add(this.pnlDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form1";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.form1_Load);
            this.pnlNumeros.ResumeLayout(false);
            this.pnlOperadores.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel pnlNumeros;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Panel pnlOperadores;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button signo;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Label opActual;
    }
}

