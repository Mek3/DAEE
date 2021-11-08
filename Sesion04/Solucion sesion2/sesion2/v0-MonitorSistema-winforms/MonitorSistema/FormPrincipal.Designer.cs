namespace MonitorSistema
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMemoriaVirtual = new System.Windows.Forms.Label();
            this.labelDiscoLecturaEscritura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDiscoLectura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDiscoEscritura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelRedRecibidos = new System.Windows.Forms.Label();
            this.labelRedEnviados = new System.Windows.Forms.Label();
            this.labelRedRecibidosEnviados = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelOrdenadorFabricante = new System.Windows.Forms.Label();
            this.labelOrdenadorModelo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelOrdenadorProcesador = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelMemoriaFisica = new System.Windows.Forms.Label();
            this.labelDiscosLogicos = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(153, 17);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(41, 13);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "<CPU>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disco";
            // 
            // labelMemoriaVirtual
            // 
            this.labelMemoriaVirtual.AutoSize = true;
            this.labelMemoriaVirtual.Location = new System.Drawing.Point(153, 91);
            this.labelMemoriaVirtual.Name = "labelMemoriaVirtual";
            this.labelMemoriaVirtual.Size = new System.Drawing.Size(35, 13);
            this.labelMemoriaVirtual.TabIndex = 4;
            this.labelMemoriaVirtual.Text = "<VM>";
            // 
            // labelDiscoLecturaEscritura
            // 
            this.labelDiscoLecturaEscritura.AutoSize = true;
            this.labelDiscoLecturaEscritura.Location = new System.Drawing.Point(153, 203);
            this.labelDiscoLecturaEscritura.Name = "labelDiscoLecturaEscritura";
            this.labelDiscoLecturaEscritura.Size = new System.Drawing.Size(46, 13);
            this.labelDiscoLecturaEscritura.TabIndex = 5;
            this.labelDiscoLecturaEscritura.Text = "<DRW>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lectura";
            // 
            // labelDiscoLectura
            // 
            this.labelDiscoLectura.AutoSize = true;
            this.labelDiscoLectura.Location = new System.Drawing.Point(153, 163);
            this.labelDiscoLectura.Name = "labelDiscoLectura";
            this.labelDiscoLectura.Size = new System.Drawing.Size(35, 13);
            this.labelDiscoLectura.TabIndex = 7;
            this.labelDiscoLectura.Text = "<DR>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Escritura";
            // 
            // labelDiscoEscritura
            // 
            this.labelDiscoEscritura.AutoSize = true;
            this.labelDiscoEscritura.Location = new System.Drawing.Point(153, 185);
            this.labelDiscoEscritura.Name = "labelDiscoEscritura";
            this.labelDiscoEscritura.Size = new System.Drawing.Size(38, 13);
            this.labelDiscoEscritura.TabIndex = 9;
            this.labelDiscoEscritura.Text = "<DW>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lectura / Escritura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Red";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 13;
            // 
            // labelRedRecibidos
            // 
            this.labelRedRecibidos.AutoSize = true;
            this.labelRedRecibidos.Location = new System.Drawing.Point(153, 257);
            this.labelRedRecibidos.Name = "labelRedRecibidos";
            this.labelRedRecibidos.Size = new System.Drawing.Size(35, 13);
            this.labelRedRecibidos.TabIndex = 15;
            this.labelRedRecibidos.Text = "<NR>";
            // 
            // labelRedEnviados
            // 
            this.labelRedEnviados.AutoSize = true;
            this.labelRedEnviados.Location = new System.Drawing.Point(153, 279);
            this.labelRedEnviados.Name = "labelRedEnviados";
            this.labelRedEnviados.Size = new System.Drawing.Size(34, 13);
            this.labelRedEnviados.TabIndex = 17;
            this.labelRedEnviados.Text = "<NS>";
            // 
            // labelRedRecibidosEnviados
            // 
            this.labelRedRecibidosEnviados.AutoSize = true;
            this.labelRedRecibidosEnviados.Location = new System.Drawing.Point(153, 302);
            this.labelRedRecibidosEnviados.Name = "labelRedRecibidosEnviados";
            this.labelRedRecibidosEnviados.Size = new System.Drawing.Size(42, 13);
            this.labelRedRecibidosEnviados.TabIndex = 19;
            this.labelRedRecibidosEnviados.Text = "<NRS>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(35, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 24);
            this.label18.TabIndex = 20;
            this.label18.Text = "Ordenador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Recibidos / Enviados";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Recibidos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(77, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 21;
            this.label16.Text = "Enviados";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(99, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 18);
            this.label19.TabIndex = 24;
            this.label19.Text = "Física";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(98, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 18);
            this.label20.TabIndex = 25;
            this.label20.Text = "Virtual";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(39, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 18);
            this.label21.TabIndex = 26;
            this.label21.Text = "Discos lógicos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(69, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 18);
            this.label22.TabIndex = 27;
            this.label22.Text = "Fabricante";
            // 
            // labelOrdenadorFabricante
            // 
            this.labelOrdenadorFabricante.AutoSize = true;
            this.labelOrdenadorFabricante.Location = new System.Drawing.Point(153, 351);
            this.labelOrdenadorFabricante.Name = "labelOrdenadorFabricante";
            this.labelOrdenadorFabricante.Size = new System.Drawing.Size(32, 13);
            this.labelOrdenadorFabricante.TabIndex = 28;
            this.labelOrdenadorFabricante.Text = "<CF>";
            // 
            // labelOrdenadorModelo
            // 
            this.labelOrdenadorModelo.AutoSize = true;
            this.labelOrdenadorModelo.Location = new System.Drawing.Point(153, 373);
            this.labelOrdenadorModelo.Name = "labelOrdenadorModelo";
            this.labelOrdenadorModelo.Size = new System.Drawing.Size(35, 13);
            this.labelOrdenadorModelo.TabIndex = 29;
            this.labelOrdenadorModelo.Text = "<CM>";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(60, 391);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(86, 18);
            this.label25.TabIndex = 30;
            this.label25.Text = "Procesador";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(65, 413);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 24);
            this.label26.TabIndex = 31;
            this.label26.Text = "Usuario";
            // 
            // labelOrdenadorProcesador
            // 
            this.labelOrdenadorProcesador.AutoSize = true;
            this.labelOrdenadorProcesador.Location = new System.Drawing.Point(153, 396);
            this.labelOrdenadorProcesador.Name = "labelOrdenadorProcesador";
            this.labelOrdenadorProcesador.Size = new System.Drawing.Size(33, 13);
            this.labelOrdenadorProcesador.TabIndex = 32;
            this.labelOrdenadorProcesador.Text = "<CP>";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(153, 421);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(27, 13);
            this.labelUsuario.TabIndex = 33;
            this.labelUsuario.Text = "<U>";
            // 
            // labelMemoriaFisica
            // 
            this.labelMemoriaFisica.AutoSize = true;
            this.labelMemoriaFisica.Location = new System.Drawing.Point(153, 69);
            this.labelMemoriaFisica.Name = "labelMemoriaFisica";
            this.labelMemoriaFisica.Size = new System.Drawing.Size(41, 13);
            this.labelMemoriaFisica.TabIndex = 34;
            this.labelMemoriaFisica.Text = "<PhM>";
            // 
            // labelDiscosLogicos
            // 
            this.labelDiscosLogicos.AutoSize = true;
            this.labelDiscosLogicos.Location = new System.Drawing.Point(153, 141);
            this.labelDiscosLogicos.Name = "labelDiscosLogicos";
            this.labelDiscosLogicos.Size = new System.Drawing.Size(33, 13);
            this.labelDiscosLogicos.TabIndex = 35;
            this.labelDiscosLogicos.Text = "<LD>";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(111, 455);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Inciciar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelDiscosLogicos);
            this.Controls.Add(this.labelMemoriaFisica);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelOrdenadorProcesador);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.labelOrdenadorModelo);
            this.Controls.Add(this.labelOrdenadorFabricante);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelRedRecibidosEnviados);
            this.Controls.Add(this.labelRedEnviados);
            this.Controls.Add(this.labelRedRecibidos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelDiscoEscritura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDiscoLectura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDiscoLecturaEscritura);
            this.Controls.Add(this.labelMemoriaVirtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Monitor de sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMemoriaVirtual;
        private System.Windows.Forms.Label labelDiscoLecturaEscritura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDiscoLectura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDiscoEscritura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelRedRecibidos;
        private System.Windows.Forms.Label labelRedEnviados;
        private System.Windows.Forms.Label labelRedRecibidosEnviados;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelOrdenadorFabricante;
        private System.Windows.Forms.Label labelOrdenadorModelo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelOrdenadorProcesador;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelMemoriaFisica;
        private System.Windows.Forms.Label labelDiscosLogicos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Timer timer1;
    }
}

