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
    /// Lógica de interacción para ctrlTabla.xaml
    /// </summary>
    public partial class ctrlTabla : UserControl
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

        private drvJSON datos { get; set; }
        
        private string _oldTitulo;

        public ctrlTabla()
        {
            InitializeComponent();

            btnVolver.Visibility = Visibility.Hidden;
            boxDetalle.Visibility = Visibility.Hidden;

            titulo = "Titulo";
            datos = new drvJSON();
        }

        private void loadData()
        {
            if (_origen != "")
            {
                datos.origen = _origen;
                datos.loadData();
                pnlDatos.Height = 30 * datos.getTotal();

                for (int i = 0; i < datos.getTotalKeys(); i++)
                {

                    Label label = new Label()
                    {
                        Name = "lblHeader_" + (i + 1).ToString(),
                        Content = datos.getKey(i),
                        Margin = new Thickness(i * 100, 0, 0, 0),
                        FontFamily = new FontFamily("Arial"),
                        FontSize = 12.0,
                        FontWeight = FontWeights.Bold,
                        Background = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                        Foreground = new SolidColorBrush(Colors.White),
                        Width = 100,
                        Height = 24,
                        HorizontalContentAlignment = HorizontalAlignment.Center
                    };

                    pnlDatos.Children.Add(label);
                }

                Label labelOps = new Label
                {
                    Name = "lblHeader_Ops",
                    Content = " ",
                    Width = 100,
                    Height = 24,
                    Margin = new Thickness(0 + (datos.getTotalKeys() * 95), 0, 0, 0),
                    Background = new SolidColorBrush(Color.FromRgb(0,0,0x33)),
                    Foreground = new SolidColorBrush(Colors.White),
                };
                pnlDatos.Children.Add(labelOps);

                for (int i = 0; i < datos.getTotal(); i++) 
                {
                    for (int j = 0; j < datos.getTotalKeys(); j++) 
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

                        Label label = new Label
                        {
                            Name = "lblData_" + (i + 1).ToString() + "_" + (j + 1).ToString(),
                            Width = 100,
                            Height = 24,
                            Content = datos.getDato(i)[datos.getKey(j)],
                            Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                            Background = bgcolor,
                            Margin = new Thickness(0 + (j * 100), 24 + (i * 24), 0, 0),
                            FontFamily = new FontFamily("Arial"),
                            FontSize = 12.0,
                            BorderThickness = new Thickness(1, 0, 0, 0)
                        };
                        pnlDatos.Children.Add(label);
                    }

                    Button boton = new Button
                    {
                        Content = "Detalle",
                        Name = "btn_" + (i + 1).ToString(),
                        Width = 70,
                        Height = 22,
                        Margin = new Thickness(2 + (datos.getTotalKeys() * 100), 25 + (i * 24), 100, 0),
                    };
                    int id = i;
                    boton.Click += (sender, EventArgs) => { btnDetalle_Click(sender, EventArgs, id); };
                    pnlDatos.Children.Add(boton);
                }
                
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e, int id)
        {
            _oldTitulo = titulo;
            titulo = "Detalle de " + datos.getDato(id)[datos.getKey(1)];
            btnVolver.Visibility = Visibility.Visible;
            ScrollViewer aux = (ScrollViewer)pnlDatos.Parent;
            aux.Visibility = Visibility.Hidden;
            // Código para mostrar el detalle del dato seleccionado.

            pnlDetalle.Children.Clear();

            for (int i = 0; i < datos.getTotalKeys(); i++)
            {
                Label auxKey = new Label
                {
                    Content = datos.getKey(i),
                    FontFamily = new FontFamily("Arial"),
                    FontSize = 12,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(10, (i * 25), 0, 0),
                    Width = 200,
                    Height = 25,
                    HorizontalContentAlignment = HorizontalAlignment.Right,
                    Background = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                    Foreground = new SolidColorBrush(Colors.White),
                };

                pnlDetalle.Children.Add(auxKey);

                Label auxDato = new Label
                {
                    Content = datos.getDato(i)[datos.getKey(i)],
                    FontFamily = new FontFamily("Arial"),
                    FontSize = 12,
                    FontWeight = FontWeights.Regular,
                    Margin = new Thickness(210, (i * 25), 0, 0),
                    Width = 100,
                    Height = 25,
                    HorizontalContentAlignment = HorizontalAlignment.Left,
                };
                pnlDetalle.Children.Add(auxDato);

            }
            boxDetalle.Visibility = Visibility.Visible;
            boxDetalle.Margin = new Thickness(10, 52, 9.6, 53);
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            titulo = _oldTitulo;
            btnVolver.Visibility = Visibility.Hidden;
            ScrollViewer aux = (ScrollViewer)pnlDatos.Parent;
            aux.Visibility = Visibility.Visible;
            boxDetalle.Visibility = Visibility.Hidden;
            boxDetalle.Margin = new
            Thickness(792, 52, -772.6, 52.6);
        }

    }
    
}
