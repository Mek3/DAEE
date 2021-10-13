using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfPersistenciaInterfaz.Properties;

namespace WpfPersistenciaInterfaz
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        static Config CONFIG = new Config();

        public static Config GetConfig()
        {
            return CONFIG;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Cargamos la configuración anterior (si existía)
            CONFIG.cargar(getFicheroConfig());
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            // TO-DO Guardamos la persistencia
            // Properties.Settings.Default.fichero_config.ToString
            CONFIG.guardar(getFicheroConfig());
        }

        private string getFicheroConfig()
        {
            return Settings.Default.fichero_config.ToString();
        }
    }
}
