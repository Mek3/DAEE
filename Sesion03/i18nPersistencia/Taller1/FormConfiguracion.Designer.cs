namespace Taller1
{
    partial class FrmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEN = new System.Windows.Forms.RadioButton();
            this.radioCA = new System.Windows.Forms.RadioButton();
            this.radioES = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColorBotonesOp = new System.Windows.Forms.Button();
            this.btnColorBotonesNum = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.btnColorTexto = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(0, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Location = new System.Drawing.Point(74, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(237, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEN);
            this.groupBox1.Controls.Add(this.radioCA);
            this.groupBox1.Controls.Add(this.radioES);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idiomas";
            // 
            // radioEN
            // 
            this.radioEN.AutoSize = true;
            this.radioEN.Location = new System.Drawing.Point(23, 75);
            this.radioEN.Name = "radioEN";
            this.radioEN.Size = new System.Drawing.Size(53, 17);
            this.radioEN.TabIndex = 2;
            this.radioEN.TabStop = true;
            this.radioEN.Text = "Inglés";
            this.radioEN.UseVisualStyleBackColor = true;
            this.radioEN.CheckedChanged += new System.EventHandler(this.radioEN_CheckedChanged);
            // 
            // radioCA
            // 
            this.radioCA.AutoSize = true;
            this.radioCA.Location = new System.Drawing.Point(23, 52);
            this.radioCA.Name = "radioCA";
            this.radioCA.Size = new System.Drawing.Size(78, 17);
            this.radioCA.TabIndex = 1;
            this.radioCA.TabStop = true;
            this.radioCA.Text = "Valenciano";
            this.radioCA.UseVisualStyleBackColor = true;
            this.radioCA.CheckedChanged += new System.EventHandler(this.radioCA_CheckedChanged);
            // 
            // radioES
            // 
            this.radioES.AutoSize = true;
            this.radioES.Location = new System.Drawing.Point(23, 29);
            this.radioES.Name = "radioES";
            this.radioES.Size = new System.Drawing.Size(63, 17);
            this.radioES.TabIndex = 0;
            this.radioES.TabStop = true;
            this.radioES.Text = "Español";
            this.radioES.UseVisualStyleBackColor = true;
            this.radioES.CheckedChanged += new System.EventHandler(this.radioES_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnColorBotonesOp);
            this.groupBox2.Controls.Add(this.btnColorBotonesNum);
            this.groupBox2.Controls.Add(this.btnColorFondo);
            this.groupBox2.Controls.Add(this.btnColorTexto);
            this.groupBox2.Location = new System.Drawing.Point(119, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fondo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto";
            // 
            // btnColorBotonesOp
            // 
            this.btnColorBotonesOp.Location = new System.Drawing.Point(118, 116);
            this.btnColorBotonesOp.Name = "btnColorBotonesOp";
            this.btnColorBotonesOp.Size = new System.Drawing.Size(116, 23);
            this.btnColorBotonesOp.TabIndex = 3;
            this.btnColorBotonesOp.Text = "Operadores";
            this.btnColorBotonesOp.UseVisualStyleBackColor = true;
            this.btnColorBotonesOp.Click += new System.EventHandler(this.btnColorBotonesOp_Click);
            // 
            // btnColorBotonesNum
            // 
            this.btnColorBotonesNum.Location = new System.Drawing.Point(118, 87);
            this.btnColorBotonesNum.Name = "btnColorBotonesNum";
            this.btnColorBotonesNum.Size = new System.Drawing.Size(116, 23);
            this.btnColorBotonesNum.TabIndex = 2;
            this.btnColorBotonesNum.Text = "Números";
            this.btnColorBotonesNum.UseVisualStyleBackColor = true;
            this.btnColorBotonesNum.Click += new System.EventHandler(this.btnColorBotonesNum_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Location = new System.Drawing.Point(118, 58);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(116, 23);
            this.btnColorFondo.TabIndex = 1;
            this.btnColorFondo.Text = "Fondo";
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // btnColorTexto
            // 
            this.btnColorTexto.Location = new System.Drawing.Point(118, 29);
            this.btnColorTexto.Name = "btnColorTexto";
            this.btnColorTexto.Size = new System.Drawing.Size(116, 23);
            this.btnColorTexto.TabIndex = 0;
            this.btnColorTexto.Text = "Texto";
            this.btnColorTexto.UseVisualStyleBackColor = true;
            this.btnColorTexto.Click += new System.EventHandler(this.btnColorTexto_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.Text = "Configuración";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEN;
        private System.Windows.Forms.RadioButton radioCA;
        private System.Windows.Forms.RadioButton radioES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColorBotonesOp;
        private System.Windows.Forms.Button btnColorBotonesNum;
        private System.Windows.Forms.Button btnColorFondo;
        private System.Windows.Forms.Button btnColorTexto;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}