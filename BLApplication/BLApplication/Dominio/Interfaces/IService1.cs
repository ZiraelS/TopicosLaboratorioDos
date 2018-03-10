using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BLApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Calculadora Basica
        [OperationContract]
        double SumaNumeros(double a, double b);

        [OperationContract]
        double RestaNumeros(double a, double b);

        [OperationContract]
        double MultiplicacionNumeros(double a, double b);

        [OperationContract]
        double DivisionNumeros(double a, double b);


        //Calculadora Cientifica 
        [OperationContract]
        double Potencia(double Numero, double Potencia);

        [OperationContract]
        double Logaritmo(double Numero);

        [OperationContract]
        double RaizCuadrada(double Numero);

        [OperationContract]
        double Factorial(double Numero);


        //Calculadora Financiera
        //CF = Ci(1+r) elevado n
        [OperationContract]
        double InteresCompuesto(double CapitalInicial, double TasaDeInteres, double NumeroPeriodos);

        // I = C * i * t
        [OperationContract]
        double InteresSimple(double Capital, double TasaDeInteres, double Tiempo);

        // Colones / ValorDolar
        [OperationContract]
        double ConvertirColonesDolares(double Colones, double ValorDolar);

        // Dolares * ValorColon
        [OperationContract]
        double ConvertirDolaresColones(double Dolares, double ValorColones);


        //Calculadora Trigonometrica
        [OperationContract]
        double Seno(double grados);

        [OperationContract]
        double Coseno(double grados);

        [OperationContract]
        double Tangente(double grados);










        //
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
