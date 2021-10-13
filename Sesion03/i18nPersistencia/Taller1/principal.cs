using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Taller1
{
    enum Operaciones { Suma, Resta, Producto, Division, Potencia };

    public partial class Principal : Form
    {
        private double operando1, operando2, resultado;
        private Operaciones operacion;
        private string lang = Program.config.lang;

        public Principal()
        {
          
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            i18n(); // importante después de InitializeComponent
            personalizacion();
            operando1 = 0;
            operando2 = 0;
            resultado = 0;

        }

        private void personalizacion()
        {
            // TODO Refactorizar código para  que se cargue aquí toda la personalización
            this.pnlDisplay.BackColor = Program.config.fondo;
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                                      "¿Realmente deseas salir?", "Calculadora",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
"Autor:David\nVersión: 0.0.1", "Acerca de: Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void doOperacion(Operaciones operaciones)
        {
            operando1 = Convert.ToDouble(lblDisplay.Text);
            operacion = operaciones;
            lblDisplay.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Sumando " + lblDisplay.Text;

            doOperacion(Operaciones.Suma);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Restando " + lblDisplay.Text;
            doOperacion(Operaciones.Resta);
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Multiplicando " + lblDisplay.Text;
            doOperacion(Operaciones.Producto);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Dividiendo " + lblDisplay.Text;
            btnCalcula.Enabled = false;
           doOperacion(Operaciones.Division);
        }


        private void btnPotencia_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Elevando " + lblDisplay.Text;
            doOperacion(Operaciones.Potencia);
        }


        private void btnBorra_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
            try
            {
                operando2 = Convert.ToDouble(lblDisplay.Text);
                switch (operacion)
                {
                    case Operaciones.Suma:
                        resultado = operando1 + operando2;
                        break;
                    case Operaciones.Resta:
                        resultado = operando1 - operando2;
                        break;
                    case Operaciones.Producto:
                        resultado = operando1 * operando2;
                        break;
                    case Operaciones.Potencia:
                        resultado = Math.Pow(operando1, operando2);
                        break;
                    case Operaciones.Division:
                        if (operando2 != 0)
                        {
                            resultado = operando1 / operando2;
                        }
                        else
                        {
                            // esto no se va a dar nunca porque lo hemos deshabiltado cuando el divisor es 0
                            MessageBox.Show("No se puede dividir por cero!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
                lblDisplay.Text = resultado.ToString();
                operando1 = 0;
                operando2 = 0;
            } catch (OverflowException ex)
            {
                MessageBox.Show("La operación ha causado un desbordamiento",
   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(lblDisplay.Text);
            if (numero != 0)
            {
                lblDisplay.Text = "-" + numero;
            }

        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains(","))
            {
                lblDisplay.Text += ",";
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(lblDisplay.Text);
            numero = Math.Sqrt(numero);
            lblDisplay.Text = "" + numero;
            operando1 = operando2 = 0;
        }

        private void menuConfig_Click(object sender, EventArgs e)
        {
            FrmConfig config = new FrmConfig();
            config.ShowDialog(this);
        }

        private void anyadirNumDisdplay(string num)
        {
            string txt = lblDisplay.Text + num;
            double numero = 0;
            try
            {
                numero = Convert.ToDouble(txt);
                lblDisplay.Text = numero.ToString();
            }
            catch { /*nada*/ }

            btnCalcula.Enabled = operacion != Operaciones.Division || numero != 0;

        }
        private void btnNumerosClick(object sender, EventArgs e)
        {
            anyadirNumDisdplay(((Button)sender).Text);
        }

        public void i18n()
        {
            menuArchivo.Text = Resource.mnArchivo; 
            menuAyuda.Text = Resource.mnAyuda;
            menuConfig.Text = Resource.mnArchivoConfiguracion; 
            menuSalir.Text = Resource.mnArchivoSalir; 
            menuAcercaDe.Text = Resource.mnAyudaAcercade;
        }

       
    }
}
