using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Taller1
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            btnColorTexto.BackColor = Program.config.texto; 
            btnColorFondo.BackColor = Program.config.fondo; 
            btnColorBotonesNum.BackColor = Program.config.botonesNUM;
            btnColorBotonesOp.BackColor = Program.config.botonesOP; 
            switch (Program.config.lang)
            {
                case "es":
                    radioES.Checked = true; break;
                case "ca":
                    radioCA.Checked = true; break;
                case "en":
                    radioEN.Checked = true; break;
                default:
                    radioES.Checked = true; break;
            }
        }

        private Color selectColor(object sender)
        {
            Button yo = (Button)sender; 
            colorPicker.Color = Color.Black; 
            colorPicker.ShowDialog(); 
            yo.BackColor = colorPicker.Color; 
            return colorPicker.Color;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnColorTexto_Click(object sender, EventArgs e)
        {
            Color c = this.selectColor(sender);
            this.Owner.ForeColor = c; 
            Program.config.texto = c;
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            Color col = this.selectColor(sender);
            foreach (Control c in this.Owner.Controls)
            {
                if (c.Name.StartsWith("pnl"))
                {
                    c.BackColor = col;
                }
            }
            Program.config.fondo = col;
        }

        private void btnColorBotonesNum_Click(object sender, EventArgs e)
        {
            Color col = this.selectColor(sender);

            Control [] panelNumeros = this.Owner.Controls.Find("pnlNumeros", true);
            if (panelNumeros == null || panelNumeros.Length !=  1)
            {
                throw new Exception("No puedo encontrar un panel 'pnlNumeros'");
            } else
            {
                foreach (Control c2 in panelNumeros[0].Controls)
                {
                    if (c2.Name == "btn1" || c2.Name == "btn2" ||
                        c2.Name == "btn3" || c2.Name == "btn4" ||
                        c2.Name == "btn5" || c2.Name == "btn6" ||
                        c2.Name == "btn7" || c2.Name == "btn8" ||
                        c2.Name == "btn9" || c2.Name == "btn0")
                    {
                        c2.BackColor = col;
                    }
                  
                }
            }
            
            Program.config.botonesNUM = col;
        }


        private void btnColorBotonesOp_Click(object sender, EventArgs e)
        {
            Color col = this.selectColor(sender);
            Control[] panelOperadores = this.Owner.Controls.Find("pnlOperadores", true);
            if (panelOperadores == null || panelOperadores.Length != 1)
            {
                throw new Exception("No puedo encontrar un panel 'pnlOperadores'");
            }
            else
            {
                foreach (Control c2 in panelOperadores[0].Controls)
                {                    
                        c2.BackColor = col;                   
                }
            }
            Program.config.botonesOP = col;
        }

        private void l10n(string lang)
        {
            Program.config.lang = lang;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Principal p = this.Owner as Principal;
            if (p != null) p.i18n();
        }

        private void radioES_CheckedChanged(object sender, EventArgs e)
        {
            l10n("es");

        }

        private void radioCA_CheckedChanged(object sender, EventArgs e)
        {
            l10n("ca");

        }

        private void radioEN_CheckedChanged(object sender, EventArgs e)
        {
            l10n("en");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fichero = Properties.Settings.Default.fichero_config.ToString();
            StreamWriter fc = new StreamWriter(fichero, false);
            fc.WriteLine(Program.config.lang);
            fc.WriteLine(Program.config.texto.Name);
            fc.WriteLine(Program.config.fondo.Name);
            fc.WriteLine(Program.config.botonesNUM.Name);
            fc.WriteLine(Program.config.botonesOP.Name);
            fc.Close();
            MessageBox.Show("Configuración almacenada correctamente en " + fichero, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
