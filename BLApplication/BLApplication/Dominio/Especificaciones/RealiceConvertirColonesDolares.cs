using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceConvertirColonesDolares
    {
        public double RealizarConvertirColonesDolares(double Colones, double ValorDolar)
        {
            double laConvertirColonesDolares;
            var laAccion = new Dominio.Acciones.HacerConvertirColonesDolares();
            laConvertirColonesDolares = laAccion.CrearConvertirColonesDolares(Colones, ValorDolar);
            return laConvertirColonesDolares;
        }
    }
}