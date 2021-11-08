using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MonitorSistema
{
    internal abstract class ComandosRecursosSistema : ICommand
    {
        protected RecursosSistema destinatario;

        public event EventHandler CanExecuteChanged;

        public ComandosRecursosSistema(RecursosSistema destinatario)
        {
            this.destinatario = destinatario;            
        }

        public void NotifyCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);

    }

    internal class ComandoReset : ComandosRecursosSistema
    {        
        public ComandoReset(RecursosSistema r) : base(r)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            destinatario.MemoriaFisicaPorcentajeMaximo.Valor = 0;
            destinatario.MemoriaVirtualPorcentajeMaximo.Valor = 0;
        }
    }

    internal class ComandoIniciar : ComandosRecursosSistema
    {
        public ComandoIniciar(RecursosSistema r) : base(r)
        {
        }

        public override bool CanExecute(object parameter)
        {
           return !destinatario.isTemporizadorIniciado();
        }

        public override void Execute(object parameter)
        {
            destinatario.iniciarTemporizador();
        }

        
    }

    internal class ComandoParar : ComandosRecursosSistema
    {
        public ComandoParar(RecursosSistema r) : base(r)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return destinatario.isTemporizadorIniciado();
        }

        public override void Execute(object parameter)
        {
            destinatario.pararTemporizador();
        }
    }

    public class RecursosSistema : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // para el cambio de estado 

        Medida cpu;
        Medida[] disco;
        Medida[] memoria;
        Medida[] red;
        String fabricante;
        string modelo;
        string usuario;
        string procesador;
        string discosLogicos;
        ICommand comandoReset;
        bool ejecutando;
        ComandosRecursosSistema comandoIniciar;
        ComandosRecursosSistema comandoParar;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        LectorRecursosSistema lectorRecursosSistema;
        public RecursosSistema()
        {
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
                new Medida("Virtual ocupada"),
                new Medida("Física porcentaje"),
                new Medida("Virtual porcentaje"),
                new Medida("Física porcentaje máximo"),
                new Medida("Virtual porcentaje máximo")

            };
            red = new Medida[] {
                new Medida("Paquetes enviados"),
                new Medida("Paquetes recibidos"),
                new Medida("Paquetes recibidos/recibidos")
            };

            lectorRecursosSistema = new LectorRecursosSistema(this);
            dispatcherTimer.Tick += new EventHandler(manejadorDispatcherTimer);
            comandoReset = new ComandoReset(this);
            comandoIniciar = new ComandoIniciar(this);
            comandoParar = new ComandoParar(this);
        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void manejadorDispatcherTimer(object sender, EventArgs e)
        {
            lectorRecursosSistema.actualiza();
        }

        internal void iniciarTemporizador()
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1); // se actualiza cada segundo
            dispatcherTimer.Start();
            ejecutando = true; // importante que esté antes de las notificaciones
            OnPropertyChanged("Ejecutando");
            comandoIniciar.NotifyCanExecuteChanged();
            comandoParar.NotifyCanExecuteChanged();
        }

        internal void pararTemporizador()
        {
            dispatcherTimer.Stop();
            ejecutando = false;
            OnPropertyChanged("Ejecutando");
            comandoIniciar.NotifyCanExecuteChanged();
            comandoParar.NotifyCanExecuteChanged();
        }

        internal bool isTemporizadorIniciado()
        {
            return ejecutando;
        }

        public Boolean Ejecutando { get => ejecutando;  }

        public Medida CPU { get => cpu; set => cpu = value; }
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
        public Medida MemoriaFisicaPorcentaje { get => memoria[4]; }
        public Medida MemoriaVirtualPorcentaje { get => memoria[5]; }
        public Medida MemoriaFisicaPorcentajeMaximo { get => memoria[6]; }
        public Medida MemoriaVirtualPorcentajeMaximo { get => memoria[7]; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string DiscosLogicos { get => discosLogicos; set => discosLogicos = value; }
        public ICommand ComandoReset { get => comandoReset; }
        public ICommand ComandoIniciar { get => comandoIniciar; }
        public ICommand ComandoParar { get => comandoParar; }
    }
}
