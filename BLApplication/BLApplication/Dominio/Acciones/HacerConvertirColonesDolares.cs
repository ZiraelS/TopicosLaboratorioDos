using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerConvertirColonesDolares
    {
        public double CrearConvertirColonesDolares(double colones, double valorDolar)
        {
            if (colones > 0 && valorDolar > 0)
            {
                return colones * valorDolar;
            }
            return 0;
        }
    }
}