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
using MonitorSistema;

namespace MonitorSistemaVentanas
{
    /// <summary>
    /// Lógica de interacción para AcercaDe.xaml
    /// </summary>
    public partial class AcercaDe : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        int frecuenciaActualización;

        public AcercaDe()
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
            labelValorProcesador.Content = "";
            if (labelValorProcesador.Content.Equals(""))
            {
                foreach (string text in ls.getProcesadores())
                {
                    labelValorProcesador.Content += text;
                }
            }

            labelMF.Content = ls.getMemoriaFisica();
            labelDR.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.Read);
            labelDW.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.Write);
            labelDRW.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.ReadAndWrite);

            labelNR.Content = ls.getDatosRed(LectorRecursosSistema.NetData.Received);
            labelNPS.Content = ls.getDatosRed(LectorRecursosSistema.NetData.Sent);
            labelNPRS.Content = ls.getDatosRed(LectorRecursosSistema.NetData.ReceivedAndSent);

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
                dispatcherTimer.Interval = new TimeSpan(0, 0, (int)this.actualizarFrecuencia.Value);//se actualiza cada segundo
                dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }

        }

        private void actualizarFrecuencia_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            actualizarDatos();
            if (dispatcherTimer.IsEnabled)
            {
                dispatcherTimer.Stop();
                btnActualizar.Content = "Iniciar";
            }
            else
            {
                dispatcherTimer.Interval = new TimeSpan(0, 0,
                                            (int)this.actualizarFrecuencia.Value);//se actualiza según el slider
                dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }
        }

        private void actualizarFrecuencia_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
