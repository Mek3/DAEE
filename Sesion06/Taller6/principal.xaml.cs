using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Estás seguro que deseas salir?",
                                        "Atención",
                                        MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnListado1_Click(object sender, RoutedEventArgs e)
        {
            winListado1 listado1 = new winListado1();
            listado1.Show();
        }

        private void btnListado2_Click(object sender, RoutedEventArgs e)
        {
            winListado2 listado2 = new winListado2();
            listado2.Show();
        }

        private void btnListado3_Click(object sender, RoutedEventArgs e)
        {
            winListado3 listado3 = new winListado3();
            listado3.Show();
        }

        private void btnGenerarPDF_Click(object sender, RoutedEventArgs e)
        {
           
            drvJSON datos = new drvJSON();
            datos.origen = "Assets\\provincias.json";
            datos.loadData();

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Provincias de España";
            
            // Page Options
            PdfPage pdfPage = document.AddPage();
            pdfPage.Height = 1500;//842
            pdfPage.Width = 590;

            // Get an XGraphics object for drawing
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            // Text format
            XStringFormat format = new XStringFormat();
            format.LineAlignment = XLineAlignment.Near;
            format.Alignment = XStringAlignment.Near;
            var tf = new XTextFormatter(graph);

            XFont fontParagraph = new XFont("Arial", 8, XFontStyle.Regular);

            // Row elements
            int el1_width = 15;
            int el2_width = 100;//380;

            // page structure options
            double lineHeight = 20;
            int marginLeft = 100;//20;
            int marginTop = 20;

            int el_height = 30;
            int rect_height = 15;

            int interLine_X_1 = 2;

            int offSetX_1 = el1_width;

            XSolidBrush rect_style1 = new XSolidBrush(XColors.LightGray);
            XSolidBrush rect_style2 = new XSolidBrush(XColors.Black);

            for (int i = 0; i < datos.getTotal(); i++)
            {
                double dist_Y = lineHeight * (i + 1);
                double dist_Y2 = dist_Y - 2;
                string provincia =  datos.getDato(i)[datos.getKey(1)];
                string id = datos.getDato(i)[datos.getKey(0)];
                // header della G
                if (i == 0)
                {
                    graph.DrawRectangle(rect_style2, marginLeft, marginTop, el2_width + el1_width + interLine_X_1, rect_height);

                    tf.DrawString("Id", fontParagraph, XBrushes.White,
                                    new XRect(marginLeft, marginTop, el1_width, el_height), format);

                    tf.DrawString("Provincia", fontParagraph, XBrushes.White,
                                    new XRect(marginLeft + offSetX_1 + interLine_X_1, marginTop, el2_width, el_height), format);

                    // stampo il primo elemento insieme all'header
                    graph.DrawRectangle(rect_style1, marginLeft, dist_Y2 + marginTop, el1_width, rect_height);
                    tf.DrawString(id, fontParagraph, XBrushes.Black,
                                    new XRect(marginLeft, dist_Y + marginTop, el1_width, el_height), format);

                    //ELEMENT 2 - BIG 380
                    graph.DrawRectangle(rect_style1, marginLeft + offSetX_1 + interLine_X_1, dist_Y2 + marginTop, el2_width, rect_height);
                    tf.DrawString(
                        provincia,
                        fontParagraph,
                        XBrushes.Black,
                        new XRect(marginLeft + offSetX_1 + interLine_X_1, dist_Y + marginTop, el2_width, el_height),
                        format);
                }
                else
                {

                    //ELEMENT 1 - SMALL 80
                    graph.DrawRectangle(rect_style1, marginLeft, marginTop + dist_Y2, el1_width, rect_height);
                    tf.DrawString(

                        id,
                        fontParagraph,
                        XBrushes.Black,
                        new XRect(marginLeft, marginTop + dist_Y, el1_width, el_height),
                        format);

                    //ELEMENT 2 - BIG 380
                    graph.DrawRectangle(rect_style1, marginLeft + offSetX_1 + interLine_X_1, dist_Y2 + marginTop, el2_width, rect_height);
                    tf.DrawString(
                        provincia,
                        fontParagraph,
                        XBrushes.Black,
                        new XRect(marginLeft + offSetX_1 + interLine_X_1, marginTop + dist_Y, el2_width, el_height),
                        format);

                }

            }

            const string filename = "Assets\\Provincias.pdf"; //"C:\\Users\\mekmo\\OneDrive\\Documentos\\MasterWeb\\DAEE\\Sesion06\\Provincias.pdf";

            document.Save(filename);
            Process.Start(filename);

        }
        


    }
}

        

