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
using Taller6.Models;

namespace Taller6
{
    /// <summary>
    /// Lógica de interacción para winListado1.xaml
    /// </summary>
    public partial class winListado1 : Window
    {
        public winListado1()
        {
            InitializeComponent();

            drvJSON provs = new drvJSON();
            provs.origen = "Assets\\provincias.json";
            provs.loadData();
            for (int i = 0; i < provs.getTotal(); i++) 
            {
                Label label = new Label()
                {
                    Name = "label_" + (i + 1).ToString(),
                    Width = Double.NaN, //label.Autorize =  true;
                    Height = 26,
                    Content = provs.getDato(i)[provs.getKey(0)] + " - "
                            + provs.getDato(i)[provs.getKey(1)],
                    Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                    Background = new SolidColorBrush(Colors.White),
                    Margin = new Thickness(50, i * 26, 0, 0)
                };
                pnlDatos.Height += 26;
                pnlDatos.Children.Add(label);
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Estás seguro que deseas salir ? ", 
                                        "Atención",
                                        MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
