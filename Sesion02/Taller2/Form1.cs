using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitorSistema;

namespace Taller2
{
    public partial class Form1 : Form
    {
        LectorRecursosSistema ls; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ls = new LectorRecursosSistema();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Ordenador
            fabricante.Text = ls.getOrdenadorFabricante();
            modelo.Text = ls.getOrdenadorModelo();
            if (procesador.Text.Equals(""))
            {
                foreach (string text in ls.getProcesadores())
                {
                    procesador.Text += text;
                }
            }
            if (timer1.Enabled)
            {
                timer1.Stop();
                button2.Text = "Iniciar";
            }
            else
            {
                timer1.Interval = 1000;
                timer1.Start();
                button2.Text = "Parar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resCpu.Text = ls.getCPU();
        }
    }
}
