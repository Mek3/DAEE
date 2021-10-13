using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domotica;

namespace TestsUnitariosDomotica
{
    public class ConectorSistemaDomoticaStub: IConectorSistemaDomotica
    {
        double posicionPersiana = 0;

        double IConectorSistemaDomotica.bajarPersiana() 
        {
            
            if (posicionPersiana >= 0.9) {
                posicionPersiana -= 0.1;
            }
            else 
            {
                posicionPersiana = 0;
            }
                return posicionPersiana;
        }

        double IConectorSistemaDomotica.subirPersiana()
        {
            if (posicionPersiana >= 0.1)
            {
                posicionPersiana += 0.1;
            }
            else
            {
                posicionPersiana = 1;
            }
                return posicionPersiana;
        }
    }
}
