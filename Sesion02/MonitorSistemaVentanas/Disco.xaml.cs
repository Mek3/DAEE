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
    /// Lógica de interacción para Disco.xaml
    /// </summary>
    public partial class Disco : Page
    {
        public Disco()
        {
            InitializeComponent();
            LectorRecursosSistema ls = new LectorRecursosSistema();
            labelDR.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.Read);
            labelDW.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.Write);
            labelDRW.Content = ls.getDatosDisco(LectorRecursosSistema.DiskData.ReadAndWrite);
        }
    }
}
