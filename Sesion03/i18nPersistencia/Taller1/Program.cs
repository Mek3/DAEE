using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    static class Program
    {
        public static Config config;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            config = new Config();
            recuperaConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

        private static void recuperaConfig()
        {
            string fichero =
            Properties.Settings.Default.fichero_config.ToString();
            if (File.Exists(fichero))
            {
                StreamReader fc = new StreamReader(fichero);
                Program.config.lang = fc.ReadLine();
                Program.config.texto = Color.FromName(fc.ReadLine());
                Program.config.fondo = Color.FromName(fc.ReadLine());
                Program.config.botonesNUM = Color.FromName(fc.ReadLine());
                Program.config.botonesOP = Color.FromName(fc.ReadLine());
                fc.Close();
            }
        }
    }
}
