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
    /// Lógica de interacción para winListado3.xaml
    /// </summary>
    public partial class winListado3 : Window
    {
        public winListado3()
        {
            InitializeComponent();
            tabla.titulo = "Listado tabular";
            tabla.origen = "Assets\\provincias.json";
        }
        private void btnCerrar_Click(object sender,
        RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
