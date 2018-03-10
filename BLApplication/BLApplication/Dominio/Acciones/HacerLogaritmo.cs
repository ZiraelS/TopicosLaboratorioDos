using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerLogaritmo
    {
        public double CrearLogaritmo(double numero)
        {
            if (numero >= 0)
            {
                return Math.Log(numero);
            }
            return 0;
        }
    }
}