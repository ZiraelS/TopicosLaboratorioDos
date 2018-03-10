using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceDivisionNumeros
    {
        public double RealizarDivisionNumeros(double a, double b)
        {
            double laDivisionNumeros;
            var laAccion = new Dominio.Acciones.HacerDivisionNumeros();
            laDivisionNumeros = laAccion.CrearDivisionNumeros(a, b);
            return laDivisionNumeros;
        }
    }
}