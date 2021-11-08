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
using System.Windows.Shapes;

namespace Taller6
{
    /// <summary>
    /// Lógica de interacción para winListado2.xaml
    /// </summary>
    public partial class winListado2 : Window
    {
        public winListado2()
        {
            InitializeComponent();
            listado.titulo = "Provincias";
            listado.origen = "Assets\\provincias.json";
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Estás seguro que deseas salir?",
                                       "Atención",
                                       MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
