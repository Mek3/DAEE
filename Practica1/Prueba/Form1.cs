using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class form1 : Form
    {
        enum Operaciones { 
            Suma, Resta, Producto, Division, Potencia
        };

        private float operando1, operando2, resultado;
        private Operaciones operacion;
        public form1()
        
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the calculate?";
            const string caption = "Form Closing";
            DialogResult resul = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            operando1 = 0;
            operando2 = 0;
            resultado = 0;
            operacion = Operaciones.Suma;
        }

        private void anyadirNumDisplay(string num) 
        {
            
            try
            {
                string text = lblDisplay.Text + num;
                if (!text.Contains(','))
                {
                    int numero = Convert.ToInt32(text);
                    lblDisplay.Text = numero.ToString();
                }
                else
                    lblDisplay.Text += num;

            }
            catch 
            {
                MessageBox.Show("Error al convertir el numero.");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.lblDisplay.AutoSize = false;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

            this.lblDisplay = new Label();
            this.lblDisplay.Location = new System.Drawing.Point(10, 10);
            this.lblDisplay.Name = "Label1";
            this.lblDisplay.TabIndex = 0;

            // Set the label to a small size, but set the AutoSize property 
            // to true. The label will adjust its length so all the text
            // is visible, however if the label is wider than the form,
            // the entire label will not be visible.
            this.lblDisplay.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(this.lblDisplay);
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Text = "The text in this label is longer" +
                " than the set size.";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Autor: Autor de la App\n Versión: 0.0.1",
                "Acerca de: Calculadora",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Números a operar
        private void btn1_Click(object sender, EventArgs e)
        {
            anyadirNumDisplay("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            anyadirNumDisplay("2");

        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("3");

        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("4");

        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("5");

        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("6");

        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("7");

        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("8");

        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("9");
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            anyadirNumDisplay("0");

        }
        
        // Operaciones + - x / 
       // private void gestionarOperacion(Operaciones operacion)
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Suma;
            lblDisplay.Text = "0";
            btnResult.Enabled = true;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Resta;
            lblDisplay.Text = "0";
            btnResult.Enabled = true;
        }


        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Producto;
            lblDisplay.Text = "0";
            btnResult.Enabled = true;
        }

       
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Division;
            lblDisplay.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text) * (-1));
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ",";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {//potencia 
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Potencia;
            lblDisplay.Text = "0";
            btnResult.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Raíz cuadrada.
            operando1 = float.Parse(lblDisplay.Text);
            operacion = Operaciones.Producto;
            lblDisplay.Text = Convert.ToString(Math.Sqrt(operando1));
            btnResult.Enabled = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void opActual_Click(object sender, EventArgs e)
        {

        }

        // 
        private void btnResult_Click(object sender, EventArgs e)
        {
           operando2 = float.Parse(lblDisplay.Text);

            try
            {

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
                    case Operaciones.Division:
                        if (operando2 != 0)
                        {
                            resultado = operando1 / operando2;
                        }
                        else
                        {

                            MessageBox.Show("No se puede dividir por cero!", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Operaciones.Potencia:
                        double x, y;

                        x = Convert.ToDouble(operando1);
                        y = Convert.ToDouble(operando2);
                        string res = Convert.ToString(Math.Pow(x, y));

                        resultado = float.Parse(res);
                        break;
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message + " La operacion de la causa un desbordamiento", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblDisplay.Text = resultado.ToString();
            operando1 = 0; operando2 = 0; resultado = 0;
            btnResult.Enabled = true;


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

    }
}
