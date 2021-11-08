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
    /// Lógica de interacción para subCrtFila.xaml
    /// </summary>
    public partial class subCrtFila : UserControl
    {
            
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value;}
        }

        private string _contenido;
        public string contenido
        {
            get { return _contenido; }
            set { _contenido = value; lblNombre.Content = _contenido; }
        }
        private string _info;
        public string info
        {
            get { return _info; }
            set { _info = value;}
        }
        private string _dato;
        public string dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public subCrtFila()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(info, "Detalle del dato: " + dato,
            MessageBoxButton.OK, MessageBoxImage.Information);
        }
       
    }
}

