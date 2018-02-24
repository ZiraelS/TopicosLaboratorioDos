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
        float SumaNumeros(float a, float b);
        [OperationContract]
        float RestaNumeros(float a, float b);
        [OperationContract]
        float MultiplicacionNumeros(float a, float b);
        [OperationContract]
        float DivisionNumeros(float a, float b);


        //Calculadora Trigonometrica 

        [OperationContract]
        float Potencia();
        [OperationContract]
        float Logaritmo();
        [OperationContract]
        float RaizCuadrada();
        [OperationContract]
        float Factorial();


        //Calculadora Financiera
        //CF = Ci(1+r) elevado n
        [OperationContract]
        float InteresCompuesto(float CapitalInicial, float TasaDeInteres, float NumeroPeriodos);
        // I = C * i * t
        [OperationContract]
        float InteresSimple(float Capital, float TasaDeInteres, float Tiempo);
        // Colones / ValorDolar
        [OperationContract]
        float ConvertirColonesDolares(float Colones, float ValorDolar);
        // Dolares * ValorColon
        [OperationContract]
        float ConvertirColaresColones(float Dolares, float ValorColones);

        //Calculadora Trigonometrica
        [OperationContract]
        float Seno();

        [OperationContract]
        float Coseno();

        [OperationContract]
        float Tangente();


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
