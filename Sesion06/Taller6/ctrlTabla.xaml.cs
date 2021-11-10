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
        private void insertarDatosCabecera()
        {
            if (_origen != "")
            {
                datos.origen = _origen;
                datos.loadData();
                pnlDatos.Height = 26 * datos.getTotal();

                for (int i = 0; i < datos.getTotalKeys(); i++)
                {

                    Button boton = new Button
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
                    int id = i;
                    boton.Click += (sender, EventArgs) => { btnOrdenar_Click(sender, EventArgs, id); };
                    pnlDatos.Children.Add(boton);

                }

                Label labelOps = new Label
                {
                    Name = "lblHeader_Ops",
                    Content = " ",
                    Width = 100,
                    Height = 24,
                    Margin = new Thickness(0 + (datos.getTotalKeys() * 95), 0, 0, 0),
                    Background = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                    Foreground = new SolidColorBrush(Colors.White),
                };
                pnlDatos.Children.Add(labelOps);
            }
        }
        private void loadData()
        {
            insertarDatosCabecera();
            insertarDatosEnTabla();
        }

        private void insertarDatosEnTabla() 
        {
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

        private void btnOrdenar_Click(object sender, EventArgs e, int id)
        {
            if (id == 0)
            {
                for (int i = 1; i < datos.getTotal(); i++)
                {
                    for (int j = 0; j < datos.getTotal(); j++)
                    {

                        if (datos.getDato(i)[datos.getKey(0)] < datos.getDato(j)[datos.getKey(0)])
                        {
                            dynamic auxDatos = datos.getDato(i);

                            datos.setDato(i, datos.getDato(j));
                            datos.setDato(j, auxDatos);

                        }
                    }
                }
                insertarDatosEnTabla();
            }
            else if (id == 1) 
            {
                for (int i = 1; i < datos.getTotal(); i++)
                {
                    for (int j = 0; j < datos.getTotal(); j++)
                    {
                        if (datos.getDato(i)[datos.getKey(1)] < datos.getDato(j)[datos.getKey(1)])
                        {
                            dynamic auxDatos = datos.getDato(i);

                            datos.setDato(i, datos.getDato(j));
                            datos.setDato(j, auxDatos);
                        }
                    }
                }
                insertarDatosEnTabla();
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e, int id)
        {
            _oldTitulo = titulo;
            titulo = "Detalle de " + datos.getDato(id)[datos.getKey(1)];
            btnVolver.Visibility = Visibility.Visible;
            ScrollViewer aux = (ScrollViewer)pnlDatos.Parent;
            aux.Visibility = Visibility.Hidden;
            btnId.Visibility = Visibility.Hidden;
            lblId.Visibility = Visibility.Hidden;
            textId.Visibility = Visibility.Hidden;
            btnTodo.Visibility = Visibility.Hidden;

            Console.WriteLine(id);
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
                    Content = datos.getDato(id)[datos.getKey(i)],
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
            btnId.Visibility = Visibility.Visible;
            lblId.Visibility = Visibility.Visible;
            textId.Visibility = Visibility.Visible;
            btnTodo.Visibility = Visibility.Visible;
        }

        private void mostrarProvincia(int ide)
        {
            
            int iAux = 0;
            bool idEncontrado = false;

           for (int j = 0; j < datos.getTotal() && !idEncontrado; j++)
            {
                if (datos.getDato(j)[datos.getKey(0)] == ide)
                {
                    iAux = j;
                    idEncontrado = true;
                }
            }
            if (idEncontrado)
            {
                pnlDatos.Children.Clear();
                insertarDatosCabecera();

                for (int j = 0; j < datos.getTotalKeys(); j++)
                {
                    SolidColorBrush bgcolor = new SolidColorBrush(Colors.LightGray);
                    
                    Label label = new Label
                    {
                        Name = "lblData_" + (iAux + 1).ToString() + "_" + (j + 1).ToString(),
                        Width = 100,
                        Height = 24,
                        Content = datos.getDato(iAux)[datos.getKey(j)],
                        Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0x33)),
                        Background = bgcolor,
                        Margin = new Thickness(0 + (j * 100), 24 + (24), 0, 0),
                        FontFamily = new FontFamily("Arial"),
                        FontSize = 12.0,
                        BorderThickness = new Thickness(1, 0, 0, 0)
                    };
                    pnlDatos.Children.Add(label);
                }

                Button boton = new Button
                {
                    Content = "Detalle",
                    Name = "btn_" + (iAux + 1).ToString(),
                    Width = 70,
                    Height = 22,
                    Margin = new Thickness(2 + (datos.getTotalKeys() * 100), 25 + (24), 100, 0),
                };
                int id = iAux;
                boton.Click += (sender, EventArgs) => { btnDetalle_Click(sender, EventArgs, id); };
                pnlDatos.Children.Add(boton);
            }
            else {
                MessageBox.Show("Provincia con " + ide + " No encontrada");
            }
        }

        private void btnId_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            Console.WriteLine(id);
            if (id > 1)
            {
                mostrarProvincia(id);
            }
           
        }

        private void btnTodo_Click(object sender, RoutedEventArgs e)
        {
            pnlDatos.Children.Clear();
            loadData();
        }
    }
    
}
