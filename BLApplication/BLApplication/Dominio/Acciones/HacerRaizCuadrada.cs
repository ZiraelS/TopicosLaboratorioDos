using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerRaizCuadrada
    {
        public double CrearRaizCuadrada(double numero)
        {
            if (numero >= 0)
            {
                return Math.Sqrt(numero);
            }
            return 0;
        }
    }
}