using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotica
{
    public interface IConectorSistemaDomotica
    {
        double subirPersiana();
        double bajarPersiana();
    }
}
