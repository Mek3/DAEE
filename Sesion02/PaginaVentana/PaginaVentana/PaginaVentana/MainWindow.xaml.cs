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

namespace PaginaVentana
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Pagina1());
        }

        private void BtnPagina2_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Pagina2());
        }

        private void BtnPagina3_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.Navigate(new Pagina3());
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            framePrincipal.GoBack();
        }

        private void BtnNuevaVentana_Click(object sender, RoutedEventArgs e)
        {
            OtraVentana otraVentana = new OtraVentana();
            otraVentana.Show();
        }
    }
}
