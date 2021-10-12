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

namespace MonitorSistemaVentanas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
       private void BtnOrdenador_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Ordenador());
        }
        
        private void BtnCPU_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new CPU());
        }

        private void BtnDisco_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Disco());
        }

        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Red());
        }
        private void BtnAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe ac = new AcercaDe();
            ac.ShowDialog();
        }
    }
}
