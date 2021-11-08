using System;
using System.ComponentModel;
using System.Windows;

namespace MonitorSistema
{
    public class Medida : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string titulo = null;

        public Medida(string titulo)
        {
            this.titulo = titulo;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        double valor;


        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;                
                OnPropertyChanged("Valor");
            }
        }

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return this.titulo + ": " + this.valor;
        }
    }
}
