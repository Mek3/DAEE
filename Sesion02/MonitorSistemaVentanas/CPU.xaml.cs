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

namespace MonitorSistemaVentanas
{
    /// <summary>
    /// Lógica de interacción para CPU.xaml
    /// </summary>
    public partial class CPU : Page
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        public CPU()
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
            labelValorCPU.Content = ls.getCPU();
            labelMV.Content = ls.getMemoriaVirtual();
            labelMF.Content = ls.getMemoriaFisica();
            
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
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);//se actualiza según el slider
                dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }
        }
    }
}
