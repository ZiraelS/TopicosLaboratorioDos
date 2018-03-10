using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceMultiplicacionNumeros
    {
        public double RealizarMultiplicacionNumeros(double a, double b)
        {
            double laMultiplicacionNumeros;
            var laAccion = new Dominio.Acciones.HacerMultiplicacionNumeros();
            laMultiplicacionNumeros = laAccion.CrearMultiplicacionNumeros(a, b);
            return laMultiplicacionNumeros;
        }

    }
}