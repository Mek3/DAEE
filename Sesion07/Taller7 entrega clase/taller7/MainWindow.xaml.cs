using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace taller7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Taller7Entities db; 

        public MainWindow()
        {
            InitializeComponent();
            db = new Taller7Entities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource productoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productoViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // productoViewSource.Source = [origen de datos genérico]
            db.Productos.Load();
            productoViewSource.Source = db.Productos.Local;

        }
    }
}
