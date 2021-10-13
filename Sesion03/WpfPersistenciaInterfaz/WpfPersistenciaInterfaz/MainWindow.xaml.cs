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

namespace WpfPersistenciaInterfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // cargamos el tamaño de la ventana de la configuración
            if (App.GetConfig().width != 0)
            {
                this.Width = App.GetConfig().width;
            }

            if (App.GetConfig().height != 0)
            {
                this.Height = App.GetConfig().height;
            }
        }

        // Véase el evento en MainWindow.xaml
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            App.GetConfig().width = (int)e.NewSize.Width;
            App.GetConfig().height = (int)e.NewSize.Height;
        }
    }
}
