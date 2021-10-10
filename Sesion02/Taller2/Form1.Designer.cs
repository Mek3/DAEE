
namespace Taller2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CPU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.memoria = new System.Windows.Forms.Label();
            this.resCpu = new System.Windows.Forms.Label();
            this.fisica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.fabricante = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.Label();
            this.procesador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU.Location = new System.Drawing.Point(44, 46);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(59, 25);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memoria
            // 
            this.memoria.AutoSize = true;
            this.memoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoria.Location = new System.Drawing.Point(44, 87);
            this.memoria.Name = "memoria";
            this.memoria.Size = new System.Drawing.Size(123, 25);
            this.memoria.TabIndex = 7;
            this.memoria.Text = "Ordenador";
            this.memoria.Click += new System.EventHandler(this.label7_Click);
            // 
            // resCpu
            // 
            this.resCpu.AutoSize = true;
            this.resCpu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resCpu.Location = new System.Drawing.Point(125, 55);
            this.resCpu.Name = "resCpu";
            this.resCpu.Size = new System.Drawing.Size(0, 13);
            this.resCpu.TabIndex = 8;
            // 
            // fisica
            // 
            this.fisica.AutoSize = true;
            this.fisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisica.Location = new System.Drawing.Point(68, 130);
            this.fisica.Name = "fisica";
            this.fisica.Size = new System.Drawing.Size(85, 20);
            this.fisica.TabIndex = 9;
            this.fisica.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Procesador";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fabricante
            // 
            this.fabricante.AutoSize = true;
            this.fabricante.Location = new System.Drawing.Point(164, 135);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(0, 13);
            this.fabricante.TabIndex = 25;
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(141, 167);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(0, 13);
            this.modelo.TabIndex = 27;
            // 
            // procesador
            // 
            this.procesador.AutoSize = true;
            this.procesador.Location = new System.Drawing.Point(164, 199);
            this.procesador.Name = "procesador";
            this.procesador.Size = new System.Drawing.Size(0, 13);
            this.procesador.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 288);
            this.Controls.Add(this.procesador);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fisica);
            this.Controls.Add(this.resCpu);
            this.Controls.Add(this.memoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CPU);
            this.Name = "Form1";
            this.Text = "Monitor de sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label memoria;
        private System.Windows.Forms.Label resCpu;
        private System.Windows.Forms.Label fisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fabricante;
        private System.Windows.Forms.Label modelo;
        private System.Windows.Forms.Label procesador;
        private System.Windows.Forms.Timer timer1;
    }
}

