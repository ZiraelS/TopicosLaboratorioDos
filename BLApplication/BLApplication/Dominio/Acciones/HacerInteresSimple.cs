using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerInteresSimple
    {
        public double CrearInteresSimple(double capital, double tasadeInteres, double tiempo)
        {
            double elResultado = 0;
            if (capital >= 0 && tasadeInteres >= 0 && tiempo >= 0)
            {
                elResultado = capital * tasadeInteres * tiempo;
            }
            return elResultado;
        }
    }
}