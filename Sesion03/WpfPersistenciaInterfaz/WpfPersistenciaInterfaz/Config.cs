using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPersistenciaInterfaz
{
    public class Config
    {
        public int width { get; set; }
        public int height { get; set; }

        public void guardar(string nombreFichero)
        {
            Trace.TraceInformation("Escribiendo el fichero de pesonalización " + nombreFichero);
            StreamWriter fc = new StreamWriter(nombreFichero, false);
            fc.WriteLine(width); 
            fc.WriteLine(height); 
            fc.Close();
        }

        public void cargar(string nombreFichero)
        {
            if (File.Exists(nombreFichero))
            {
                Trace.TraceInformation("Cargando el fichero de pesonalización " + nombreFichero);
                StreamReader fc = new StreamReader(nombreFichero);
                width = Int32.Parse(fc.ReadLine());
                height = Int32.Parse(fc.ReadLine());
                fc.Close();
            } else
            {
                Trace.TraceInformation("No existe el fichero de pesonalización " + nombreFichero);

            }
        }
    }

    
}
