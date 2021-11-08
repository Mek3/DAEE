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
using Taller6.Models;

namespace Taller6
{
    /// <summary>
    /// Lógica de interacción para ctrlListado.xaml
    /// </summary>
    public partial class ctrlListado : UserControl
    {
        private string _titulo;
        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; lblTitulo.Content = _titulo; }
        }
        private string _origen;
        public string origen
        {
            get { return _origen; }
            set { _origen = value; loadData(); }
        }

        private void loadData()
        {
            if(_origen!="")
            {
                datos.origen = _origen;
                datos.loadData();

                for (int i = 0; i < datos.getTotal(); i++) 
                {
                    subCrtFila fila = new subCrtFila();
                    fila.contenido = datos.getDato(i)[datos.getKey(0)] + " - "
                                    + datos.getDato(i)[datos.getKey(1)];
                    fila.info = datos.getKey(0) + ": " + datos.getDato(i)[datos.getKey(0)] +
                         "\n" + datos.getKey(1) + ": " + datos.getDato(i)[datos.getKey(1)];
                    fila.dato = datos.getDato(i)[datos.getKey(0)];

                    SolidColorBrush bgcolor;
                    if (i % 2 == 0)
                    {
                        bgcolor = new SolidColorBrush(Colors.White);
                    }
                    else 
                    {
                        bgcolor = new SolidColorBrush(Colors.LightGray);
                    }

                    fila.Background = bgcolor;
                    fila.Name = "fila" + i.ToString();
                    fila.Margin = new Thickness(50, i * 26, 0, 0);
                    pnlDatos.Height += 26;
                    pnlDatos.Children.Add(fila);
                }
            }
        }

        private drvJSON datos { get; set; }
        public ctrlListado()
        {
            InitializeComponent();

            titulo = "Titulo";
            datos = new drvJSON();
        }

        /*private void btnDetalle_Click(object sender, EventArgs e, int id)
        {
            string info = datos.getKey(0) + ": " + datos.getDato(id)[datos.getKey(0)];
            info += "\n" + datos.getKey(1) + ": " + datos.getDato(id)[datos.getKey(1)];

            MessageBox.Show(info, "Detalle del dato: " + datos.getDato(id)[datos.getKey(0)],
                MessageBoxButton.OK, MessageBoxImage.Information);
        }*/
    }
}
