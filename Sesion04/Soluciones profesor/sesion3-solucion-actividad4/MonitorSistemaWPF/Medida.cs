using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorSistemaWPF
{
    public class Medida : INotifyPropertyChanged
    {
        string titulo;
        double valor;

        public Medida(string titulo)
        {
            this.Titulo = titulo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public double Valor {
            get => valor;
            set 
            {
                valor = value;
                //Console.WriteLine(">" + Titulo + " " + Valor);
                OnPropertyChanged("Valor");
            }
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
