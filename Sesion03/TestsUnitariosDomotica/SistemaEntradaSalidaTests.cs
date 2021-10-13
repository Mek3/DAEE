using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domotica;

namespace TestsUnitariosDomotica
{
    [TestClass]
    public class SistemaEntradaSalidaTests
    {
        [TestMethod]
        public void TestSubida()
        {
            IConectorSistemaDomotica conector = new ConectorSistemaDomoticaStub();

            double posicion = conector.bajarPersiana();
            Assert.AreEqual(0.0, posicion);

            double NuevaPosicion = conector.subirPersiana();
            Assert.IsTrue(NuevaPosicion > posicion);

        }

        [TestMethod]
        public void TestMaxNumsubida() 
        {
            IConectorSistemaDomotica conector = new ConectorSistemaDomoticaStub();
            double posicion = 0, numIteracionesSubida = 0, numItercionesBajada = 0;

            do
            {
                posicion = conector.subirPersiana();
                numIteracionesSubida++;

            } while (posicion < 1);

            Assert.IsTrue(numIteracionesSubida < 10000);
            
           do
            {
                posicion = conector.bajarPersiana();
                numItercionesBajada++;

            } while (posicion > 0);

            Assert.IsTrue(numItercionesBajada < 10000);

        }


    }
}
