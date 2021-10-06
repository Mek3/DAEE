using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    enum Operaciones { Suma, Resta, Producto, Division };

    public partial class Principal : Form
    {
        private int operando1, operando2, resultado;
        private Operaciones operacion;

        public Principal()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Autor de la App\nVersión: 0.0.1", "Acerca de: Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(labelDisplay.Text);
            operacion = Operaciones.Suma;
            labelDisplay.Text = "0";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            operando2 = Convert.ToInt32(labelDisplay.Text);
            switch (operacion) {
                case Operaciones.Suma:
                    resultado = operando1 + operando2;
                    break;
                case Operaciones.Resta:
                    resultado = operando1 - operando2;
                    break;
            }
            labelDisplay.Text = resultado.ToString();
            operando1 = 0;
            operando2 = 0;
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(labelDisplay.Text);
            operacion = Operaciones.Resta;
            labelDisplay.Text = "0";
        }

        private void anyadirNumDisdplay(String num)
        {
            int numero = Convert.ToInt32(labelDisplay.Text + num);
            labelDisplay.Text = numero.ToString();
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            anyadirNumDisdplay(((Button)sender).Text);
        }
    }
}
