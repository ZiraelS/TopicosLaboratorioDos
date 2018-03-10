using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BLApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //Calculadora Basica
        public double SumaNumeros(double a, double b)
        {
            double Suma;
            var laEspecificacion = new Dominio.Especificaciones.RealiceSumaNumeros();
            Suma = laEspecificacion.RealizarSumaNumeros(a, b);
            return Suma;
        }

        public double RestaNumeros(double a, double b)
        {
            double Resta;
            var laEspecificacion = new Dominio.Especificaciones.RealiceRestaNumeros();
            Resta = laEspecificacion.RealizarRestaNumeros(a, b);
            return Resta;
        }

        public double MultiplicacionNumeros(double a, double b)
        {
            double Multiplicacion;
            var laEspecificacion = new Dominio.Especificaciones.RealiceMultiplicacionNumeros();
            Multiplicacion = laEspecificacion.RealizarMultiplicacionNumeros(a, b);
            return Multiplicacion;
        }

        public double DivisionNumeros(double a, double b)
        {
            double Division;
            var laEspecificacion = new Dominio.Especificaciones.RealiceDivisionNumeros();
            Division = laEspecificacion.RealizarDivisionNumeros(a, b);
            return Division;
        }


        //Calculadora Cientifica 
        public double Potencia(double Numero, double Potencia)
        {
            double laPotencia;
            var laEspecificacion = new Dominio.Especificaciones.RealicePotencia();
            laPotencia = laEspecificacion.RealizarPotencia(Numero, Potencia);
            return laPotencia;
        }

        public double Logaritmo(double Numero)
        {
            double elLogaritmo;
            var laEspecificacion = new Dominio.Especificaciones.RealiceLogaritmo();
            elLogaritmo = laEspecificacion.RealizarLogaritmo(Numero);
            return elLogaritmo;
        }

        public double RaizCuadrada(double Numero)
        {
            double laRaizCuadrada;
            var laEspecificacion = new Dominio.Especificaciones.RealiceRaizCuadrada();
            laRaizCuadrada = laEspecificacion.RealizarCuadrada(Numero);
            return laRaizCuadrada;
        }

        public double Factorial(double Numero)
        {
            double laFactorial;
            var laEspecificacion = new Dominio.Especificaciones.RealiceFactorial();
            laFactorial = laEspecificacion.RealizarFactorial(Numero);
            return laFactorial;
        }



        //Calculadora Financiera
        public double InteresCompuesto(double CapitalInicial, double TasaDeInteres, double NumeroPeriodos)
        {
            double CapitalFinal;
            var laEspecificacion = new Dominio.Especificaciones.RealiceInteresCompuesto();
            CapitalFinal = laEspecificacion.RealizarInteresCompuesto(CapitalInicial, TasaDeInteres, NumeroPeriodos); 
            return CapitalFinal;
        }

        public double InteresSimple(double Capital, double TasaDeInteres, double Tiempo)
        {
            double Interes;
            var laEspecificacion = new Dominio.Especificaciones.RealiceInteresSimple();
            Interes = laEspecificacion.RealizarInteresSimple(Capital, TasaDeInteres, Tiempo);
            return Interes;
        }

        public double ConvertirColonesDolares(double Colones, double ValorDolar)
        {
            double Dolares;
            var laEspecificacion = new Dominio.Especificaciones.RealiceConvertirColonesDolares();
            Dolares = laEspecificacion.RealizarConvertirColonesDolares(Colones, ValorDolar);
            return Dolares;
        }

        public double ConvertirDolaresColones(double Dolares, double ValorColones)
        {
            double CapitalFinal;
            var laEspecificacion = new Dominio.Especificaciones.RealiceConvertirDolaresColones();
            CapitalFinal = laEspecificacion.RealizarConvertirDolaresColones(Dolares, ValorColones);
            return CapitalFinal;
        }


        //Calculadora Trigonometrica
        //Radianes = Pi (Default de la PC)
        // Grados = (n x Pi) / 180
        public double Seno(double grados)
        {
            double elSen;
            var laEspecificacion = new Dominio.Especificaciones.RealiceSeno();
            elSen = laEspecificacion.RealizarSeno(grados);
            return elSen;
        }

        public double Coseno(double grados)
        {
            double elCos;
            var laEspecificacion = new Dominio.Especificaciones.RealiceCoseno();
            elCos = laEspecificacion.RealizarCoseno(grados);
            return elCos;
        }

        public double Tangente(double grados)
        {
            double laTan;
            var laEspecificacion = new Dominio.Especificaciones.RealiceTangente();
            laTan = laEspecificacion.RealizarTangente(grados);
            return laTan;
        }






        //
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
