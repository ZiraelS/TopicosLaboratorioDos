using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double digito1;
            double digito2;
            double digito3;
            double resultado;
            var WCF = new BLApplication.Service1();
            string entrada;
            int opc = 0;
            do
            {
                Console.Write("Seleccione una de las siguientes opciones: \n" +
                    "1) Multiplicacion \n" +
                    "2) Division \n" +
                    "3) Logaritmo \n" +
                    "4) Raiz Cuadrada \n" +
                    "5) Interes Simple \n" +
                    "6) Conversion de Colones a Dolares \n" +
                    "7) Seno \n" +
                    "8) Coseno \n" +
                    "0) Salir \n");
                entrada = Console.ReadLine();
                opc = int.Parse(entrada);
                switch (opc)
                {
                    case 1:
                        Console.Write("\n Multiplicacion \n" +
                            "Digite el primer digito: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        Console.Write("Digite el segundo digito: ");
                        entrada = Console.ReadLine();
                        digito2 = double.Parse(entrada);
                        resultado = WCF.MultiplicacionNumeros(digito1, digito2);
                        Console.Write("El resultado de la Multiplicacion de " + digito1 + " x " + digito2 + " = " + resultado + "\n\n");
                        break;

                    case 2:
                        Console.Write("\n Division \n" +
                            "Digite el primer digito: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        Console.Write("Digite el segundo digito: ");
                        entrada = Console.ReadLine();
                        digito2 = double.Parse(entrada);
                        resultado = WCF.DivisionNumeros(digito1, digito2);
                        Console.Write("El resultado de la Division de " + digito1 + " / " + digito2 + " = " + resultado + "\n\n");
                        break;

                    case 3:
                        Console.Write("\n Logaritmo \n" + 
                            "Digite el digito: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        resultado = WCF.Logaritmo(digito1);
                        Console.Write("El resultado del Logaritmo de " + digito1 + " = " + resultado + "\n\n");
                        break;

                    case 4:
                        Console.Write("\n Raiz Cuadrada \n" +
                            "Digite el digito: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        resultado = WCF.RaizCuadrada(digito1);
                        Console.Write("El resultado de la Raiz Cuadrada de " + digito1 + " = " + resultado + "\n\n");
                        break;

                    case 5:
                        Console.Write("\n Interes Simple \n" +
                            "Digite el Capital: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        Console.Write("Digite la Tasa de Interes: ");
                        entrada = Console.ReadLine();
                        digito2 = double.Parse(entrada);
                        Console.Write("Digite el Tiempo: ");
                        entrada = Console.ReadLine();
                        digito3 = double.Parse(entrada);
                        resultado = WCF.InteresSimple(digito1, digito2, digito3);
                        Console.Write("El resultado del Interes Simple con el Capital: " + digito1 + ", la Tasa de Interes " + digito2 + " y el Tiempo " + digito3 + " = " + resultado + "\n\n");
                        break;

                    case 6:
                        Console.Write("\n Conversion de Colones a Dolares \n" + 
                            "Digite los Colones: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        digito2 = 582.0; //Como Conectar a la base de Datos del Banco Central
                        resultado = WCF.ConvertirColonesDolares(digito1, digito2);
                        Console.Write("El resultado de la Conversion de Colones " + digito1 + " con el Valor del Dolar en " + digito2 + " = "+ resultado + "\n\n");
                        break;

                    case 7:
                        Console.Write("\n Seno \n" +
                            "Digite los Grados: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        resultado = WCF.Seno(digito1);
                        Console.Write("El resultado del Seno de " + digito1 + " = " + resultado + "\n\n");
                        break;

                    case 8:
                        Console.Write("\n Coseno \n" +
                            "Digite los Grados: ");
                        entrada = Console.ReadLine();
                        digito1 = double.Parse(entrada);
                        resultado = WCF.Tangente(digito1);
                        Console.Write("El resultado del Coseno de " + digito1 + " = " + resultado + "\n\n");
                        break;

                    case 0:
                        Console.Write("\n Va a Salir. \n");
                        break;

                    default:
                        Console.Write("\n Digite una opcion valida. \n");
                        break;
                }
                Console.ReadLine();// System Pause
            } while (opc != 0);
        }
    }
}
