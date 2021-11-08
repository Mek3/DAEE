using MonitorSistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MonitorSistema.LectorRecursosSistema;

namespace MonitorSistemaWPF
{
    class RecursosSistema
    {        
        LectorRecursosSistema lectorRecursosSistema;
        System.Windows.Threading.DispatcherTimer dispatcherTimer;

        Medida cpu;
        Medida[] disco;
        Medida[] memoria;
        Medida[] red;
        string fabricante = "N/A";
        string modelo;
        string usuario;
        string procesador;
        string discosLogicos;

        public RecursosSistema()
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += manejadorDispatcherTimer;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            lectorRecursosSistema = new LectorRecursosSistema();

            cpu = new Medida("CPU");
            disco = new Medida[]
            {
                new Medida("Lectura"),
                new Medida("Escritura"),
                new Medida("Lectura/Escritura")
            };
            memoria = new Medida[] {
                new Medida("Física disponible"),
                new Medida("Física ocupada"),
                new Medida("Virtual disponible"),
                new Medida("Virtual ocupada")
            };
            red = new Medida[] {
                new Medida("Paquetes enviados"),
                new Medida("Paquetes recibidos"),
                new Medida("Paquetes recibidos/recibidos")
            };
        }

        public Medida Cpu { get => cpu; set => cpu = value; }
        public Medida[] Disco { get => disco; set => disco = value; }
        public Medida[] Memoria { get => memoria; set => memoria = value; }
        public Medida[] Red { get => red; set => red = value; }
        public Medida DiscoLectura { get => disco[0]; }
        public Medida DiscoEscritura { get => disco[1]; }
        public Medida DiscoLecturaEscritura { get => disco[2]; }
        public Medida RedPaquetesEntrada { get => red[0]; }
        public Medida RedPaquetesSalida { get => red[1]; }
        public Medida RedPaquetesEntradaSalida { get => red[2]; }
        public Medida MemoriaFisicaDisponible { get => memoria[0]; }
        public Medida MemoriaFisicaOcupada { get => memoria[1]; }
        public Medida MemoriaVirtualDisponible { get => memoria[2]; }
        public Medida MemoriaVirtualOcupada { get => memoria[3]; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string DiscosLogicos { get => discosLogicos; set => discosLogicos = value; }


        public void iniciar()
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1); // se actualiza cada segundo
            dispatcherTimer.Start();
        }

        public void parar()
        {
            dispatcherTimer.Stop();
        }

        public bool ejecutandose()
        {
            return dispatcherTimer.IsEnabled;
        }

        private void manejadorDispatcherTimer(object sender, EventArgs e)
        {
            this.DiscoLectura.Valor = lectorRecursosSistema.getDatosDisco(DiskData.Read);
            this.DiscoEscritura.Valor = lectorRecursosSistema.getDatosDisco(DiskData.Write);
            this.DiscoLecturaEscritura.Valor = lectorRecursosSistema.getDatosDisco(DiskData.ReadAndWrite);

            this.MemoriaFisicaDisponible.Valor = lectorRecursosSistema.getMemoriaFisicaDisponible();
            this.MemoriaFisicaOcupada.Valor = lectorRecursosSistema.getMemoriaFisicaOcupada();
            this.MemoriaVirtualDisponible.Valor = lectorRecursosSistema.getMemoriaVirtualDisponible();
            this.MemoriaVirtualOcupada.Valor = lectorRecursosSistema.getMemoriaVirtualOcupada();

            this.RedPaquetesEntrada.Valor = lectorRecursosSistema.getDatosRed(NetData.Received);
            this.RedPaquetesSalida.Valor = lectorRecursosSistema.getDatosRed(NetData.Sent);
            this.RedPaquetesEntradaSalida.Valor = lectorRecursosSistema.getDatosRed(NetData.ReceivedAndSent);

            this.fabricante = lectorRecursosSistema.getOrdenadorFabricante();

            this.cpu.Valor = lectorRecursosSistema.getCPU();
            this.memoria[0].Valor = lectorRecursosSistema.getMemoriaFisica();
            this.memoria[1].Valor = lectorRecursosSistema.getMemoriaVirtual();
        }
    }
}
