using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceRestaNumeros
    {
        public double RealizarRestaNumeros(double a, double b)
        {
            double laRestaNumeros;
            var laAccion = new Dominio.Acciones.HacerRestaNumeros();
            laRestaNumeros = laAccion.CrearRestaNumeros(a, b);
            return laRestaNumeros;
        }

    }
}