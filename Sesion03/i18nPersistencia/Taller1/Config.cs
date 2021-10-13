using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Config
    {
        public string lang { get; set; }
        public Color texto { get; set; }
        public Color fondo { get; set; }
        public Color botonesNUM { get; set; }
        public Color botonesOP { get; set; }

        public Config()
        {
            lang = "es";
            texto = SystemColors.ControlText; 
            fondo = SystemColors.ControlLightLight; 
            botonesNUM = SystemColors.ControlLight; 
            botonesOP = SystemColors.ControlLight;
        }

    }
}
