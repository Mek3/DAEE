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
                    SolidColorBrush bgcolor;
                    if (i % 2 == 0)
                    {
                        bgcolor = new SolidColorBrush(Colors.White);
                    }
                    else 
                    {
                        bgcolor = new SolidColorBrush(Colors.LightGray);
                    }

                    Label label = new Label()
                    {
                        Name = "label_" + (i + 1).ToString(),
                        Width = Double.NaN, //label.Autorize =  true;
                        Height = 26,
                        Content = datos.getDato(i)[datos.getKey(0)] + " - "
                           + datos.getDato(i)[datos.getKey(1)],
                        Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                        Background = bgcolor,
                        Margin = new Thickness(50, i * 26, 0, 0)
                    };

                    Button boton = new Button
                    {
                        Content = "Detalles",
                        Name = "btn_" + (i + 1).ToString(),
                        Width = 70,
                        Height = 22,
                        Margin = new Thickness(655, (i * 26) + 2, 0, 0),
                        Background = bgcolor
                    };
                    int id = i;
                    boton.Click += (sender, EventArgs) => { btnDetalle_Click(sender, EventArgs, id); };
                    pnlDatos.Height += 26;
                    pnlDatos.Children.Add(label);
                    pnlDatos.Children.Add(boton);
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

        private void btnDetalle_Click(object sender, EventArgs e, int id)
        {
            string info = datos.getKey(0) + ": " + datos.getDato(id)[datos.getKey(0)];
            info += "\n" + datos.getKey(1) + ": " + datos.getDato(id)[datos.getKey(1)];

            MessageBox.Show(info, "Detalle del dato: " + datos.getDato(id)[datos.getKey(0)],
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
