using System;


namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceSumaNumeros
    {
        public double RealizarSumaNumeros(double a, double b)
        {
            double laSumaNumeros;
            var laAccion = new Dominio.Acciones.HacerSumaNumeros();
            laSumaNumeros = laAccion.CrearSumaNumeros(a, b);
            return laSumaNumeros;
        }
    }
}