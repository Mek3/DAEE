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
using MonitorSistema;

namespace MonitorSistemaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer ;
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(manejadorDispatcherTimer);
        }
        private void manejadorDispatcherTimer(object sender, EventArgs e)
        {
            actualizarDatos();
        }
        private void actualizarDatos() 
        {
            LectorRecursosSistema ls = new LectorRecursosSistema();
            //Ordenador
            labelValorFabricante.Content = ls.getOrdenadorFabricante();
            labelValorModelo.Content = ls.getOrdenadorModelo();
            labelValorCPU.Content = ls.getCPU();
            labelMV.Content = ls.getMemoriaVirtual();
            /* labelDR.Content = ls.
             labelDW.Content = 
             labelDRW.Content =*/
            //labelNR.Content = ls.getDatosRed();
            /*labelNPS.Content = ls.
            labelNPRS.Content =*/
            if (labelValorProcesador.Content.Equals(""))
            {
                foreach (string text in ls.getProcesadores())
                {
                    labelValorProcesador.Content += text;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            actualizarDatos();
            if (dispatcherTimer.IsEnabled)
            {
                dispatcherTimer.Stop();
                btnActualizar.Content = "Iniciar";
            }
            else
            {
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);//se actualiza cada segundo
                dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }
          
        }

        private void actualizarFrecuencia_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
