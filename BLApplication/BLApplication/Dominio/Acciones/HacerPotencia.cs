using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerPotencia
    {
        public double CrearPotencia(double numero, double potencia)
        {
            return Math.Pow(numero, potencia);
        }
    }
}