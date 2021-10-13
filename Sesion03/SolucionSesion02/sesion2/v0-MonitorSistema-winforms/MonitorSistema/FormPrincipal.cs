using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MonitorSistema.LectorRecursosSistema;

namespace MonitorSistema
{
    public partial class FormPrincipal : Form
    {
        LectorRecursosSistema lectorRecursosSistema = new LectorRecursosSistema();
 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnActualizar.Text = "Iniciar";
            } else
            {
                timer1.Interval = 1000;
                timer1.Start();
                btnActualizar.Text = "Parar";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelCPU.Text = lectorRecursosSistema.getCPU();
            this.labelDiscoLectura.Text = lectorRecursosSistema.getDatosDisco(DiskData.Read).ToString();
            this.labelDiscoEscritura.Text = lectorRecursosSistema.getDatosDisco(DiskData.Write).ToString();
            this.labelDiscoLecturaEscritura.Text = lectorRecursosSistema.getDatosDisco(DiskData.ReadAndWrite).ToString();
            this.labelRedRecibidos.Text = lectorRecursosSistema.getDatosRed(NetData.Received).ToString(); ;
            this.labelRedEnviados.Text = lectorRecursosSistema.getDatosRed(NetData.Sent).ToString(); ;
            this.labelRedRecibidosEnviados.Text = lectorRecursosSistema.getDatosRed(NetData.ReceivedAndSent).ToString();
            this.labelDiscosLogicos.Text = lectorRecursosSistema.getDiscosLogicos();
            this.labelMemoriaFisica.Text = lectorRecursosSistema.getMemoriaFisica();
            this.labelMemoriaVirtual.Text = lectorRecursosSistema.getMemoriaVirtual();
            this.labelOrdenadorFabricante.Text = lectorRecursosSistema.getOrdenadorFabricante();
            this.labelOrdenadorModelo.Text = lectorRecursosSistema.getOrdenadorModelo();
            this.labelOrdenadorProcesador.Text = lectorRecursosSistema.getProcesadores()[0];
            this.labelUsuario.Text = lectorRecursosSistema.getUsuario();
        }
    }
}
