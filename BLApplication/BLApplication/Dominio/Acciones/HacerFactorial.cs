using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerFactorial
    {
        public double CrearFactorial(double numero)
        {
            double elResultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                elResultado = elResultado * i;
            }
            return elResultado;
        }
    }
}