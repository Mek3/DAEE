﻿using MonitorSistema;
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
using static MonitorSistema.LectorRecursosSistema;

namespace MonitorSistemaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // RecursosSistema recursosSistema;
      
        public MainWindow()
        {
            // recursosSistema = new RecursosSistema();
            // Lo ponemos en el XAML this.DataContext = recursosSistema;
            InitializeComponent();
        }

    }
}
