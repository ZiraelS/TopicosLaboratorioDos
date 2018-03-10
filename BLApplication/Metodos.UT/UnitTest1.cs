using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Metodos.UT
{
    [TestClass]
    public class UnitTest1
    {

        double elResultadoActual;
        double elResultadoEsperado;
        BLApplication.IService1 elMetodo = new BLApplication.Service1();

        [TestMethod]
        public void PruebaPotenciaExito1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 4.0;

            // invocar al método
            elResultadoActual = elMetodo.Potencia(2.0 , 2.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaPotenciaExito2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 4194304.0;

            // invocar al método
            elResultadoActual = elMetodo.Potencia(2.0, 22.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaPotenciaFallo1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 50.0;

            // invocar al método
            elResultadoActual = elMetodo.Potencia(6.0, 10.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaPotenciaFallo2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 10.0;

            // invocar al método
            elResultadoActual = elMetodo.Potencia(1.0, 3.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaConvertirDolaresAColonesExito1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 2750.0;

            // invocar al método
            elResultadoActual = elMetodo.ConvertirDolaresColones(5.0, 550.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaConvertirDolaresAColonesExito2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 55000.0;

            // invocar al método
            elResultadoActual = elMetodo.ConvertirDolaresColones(100.0, 550.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaConvertirDolaresAColonesFallo1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 10000.0;

            // invocar al método
            elResultadoActual = elMetodo.ConvertirDolaresColones(205.0, 550.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaConvertirDolaresAColonesFallo2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 50.0;

            // invocar al método
            elResultadoActual = elMetodo.ConvertirDolaresColones(50.0, 550.0);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaTangenteExito1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 0.577350269;

            // invocar al método
            elResultadoActual = elMetodo.Tangente(0.52359877559);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaTangenteExito2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 1.000000000;

            // invocar al método
            elResultadoActual = elMetodo.Tangente(0.78539816339);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaTangenteFallo1()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 1.0;

            // invocar al método
            elResultadoActual = elMetodo.Tangente(0.20);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

        [TestMethod]
        public void PruebaTangenteFallo2()
        {
            // preparar el escenario
            elResultadoActual = 0.0;
            elResultadoEsperado = 0.0;

            // invocar al método
            elResultadoActual = elMetodo.Tangente(0.5070);

            // verificar el resultado
            Assert.AreEqual(elResultadoActual, elResultadoEsperado);
        }

    }
}
