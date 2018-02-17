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
        //Calculadora Financiera
        public float InteresCompuesto(float CapitalInicial, float TasaDeInteres, float NumeroPeriodos)
        {
            float CapitalFinal;
            var laEspecificacion = new Dominio.Especificaciones.RealiceInteresCompuesto();
            CapitalFinal = laEspecificacion.RealizarInteresCompuesto(CapitalInicial, TasaDeInteres, NumeroPeriodos); 
            return CapitalFinal;
        }

        public float InteresSimple(float Capital, float TasaDeInteres, float Tiempo)
        {
            float Interes;
            var laEspecificacion = new Dominio.Especificaciones.RealiceInteresSimple();
            Interes = laEspecificacion.RealizarInteresSimple(Capital, TasaDeInteres, Tiempo);
            return Interes;
        }

        public float ConvertirColonesDolares(float Colones, float ValorDolar)
        {
            float Dolares;
            var laEspecificacion = new Dominio.Especificaciones.RealiceConvertirColonesDolares();
            Dolares = laEspecificacion.RealizarInteresCompuesto(Colones, ValorDolar);
            return Dolares;
        }

        public float ConvertirColaresColones(float Dolares, float ValorColones)
        {
            float CapitalFinal;
            var laEspecificacion = new Dominio.Especificaciones.RealiceConvertirDolaresColones();
            CapitalFinal = laEspecificacion.RealizarInteresCompuesto(Dolares, ValorColones);
            return CapitalFinal;
        }


        //Calculadora Trigonometrica
        //Radianes = Pi (Default de la PC)
        // Grados = (n x Pi) / 180







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
