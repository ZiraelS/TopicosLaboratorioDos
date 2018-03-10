using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerInteresCompuesto
    {
        public double CrearInteresCompuesto(double capitalInicial, double tasaDeInteres, double numeroPeriodos)
        {
            double elResultado = 0;
            if (capitalInicial > 0 && tasaDeInteres > 0 && numeroPeriodos > 0)
            {
                elResultado = capitalInicial* Math.Pow(1+tasaDeInteres, numeroPeriodos);
            }
            return elResultado;
        }
    }
}