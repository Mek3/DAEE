using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MonitorSistema;

namespace MonitorSistemaVentanas
{
    /// <summary>
    /// Lógica de interacción para Ordenador.xaml
    /// </summary>
    public partial class Ordenador : Page
    {
        public Ordenador()
        {
            InitializeComponent();
            LectorRecursosSistema ls = new LectorRecursosSistema();
            //Ordenador
            labelValorFabricante.Content = ls.getOrdenadorFabricante();
            labelValorModelo.Content = ls.getOrdenadorModelo();
            labelValorProcesador.Content = "";
            if (labelValorProcesador.Content.Equals(""))
            {
                foreach (string text in ls.getProcesadores())
                {
                    labelValorProcesador.Content += text;
                }
            }
        }

        
    }
}
