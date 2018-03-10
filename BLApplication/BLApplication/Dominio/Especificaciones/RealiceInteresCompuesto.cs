using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceInteresCompuesto
    {
        public double RealizarInteresCompuesto(double CapitalInicial, double TasaDeInteres, double NumeroPeriodos)
        {
            double elInteresCompuesto;
            var laAccion = new Dominio.Acciones.HacerInteresCompuesto();
            elInteresCompuesto = laAccion.CrearInteresCompuesto(CapitalInicial, TasaDeInteres, NumeroPeriodos);
            return elInteresCompuesto;
        }
    }
}