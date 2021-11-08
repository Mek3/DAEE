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

namespace Taller6
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

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Estás seguro que deseas salir?",
                                        "Atención",
                                        MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnListado1_Click(object sender, RoutedEventArgs e)
        {
            winListado1 listado1 = new winListado1();
            listado1.Show();
        }

        private void btnListado2_Click(object sender, RoutedEventArgs e)
        {
            winListado2 listado2= new winListado2();
            listado2.Show();
        }

        private void btnListado3_Click(object sender, RoutedEventArgs e)
        {
            winListado3 listado3 = new winListado3();
            listado3.Show();
        }
    }
}
