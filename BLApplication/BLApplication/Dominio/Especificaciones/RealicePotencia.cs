using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealicePotencia
    {
        public double RealizarPotencia(double numero, double potencia)
        {
            double laPotencia;
            var laAccion = new Dominio.Acciones.HacerPotencia();
            laPotencia = laAccion.CrearPotencia(numero, potencia);
            return laPotencia;
        }
    }
}