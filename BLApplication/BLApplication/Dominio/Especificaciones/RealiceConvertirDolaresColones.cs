using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceConvertirDolaresColones
    {
        public double RealizarConvertirDolaresColones(double dolares, double valorColones)
        {
            double laConvertirDolaresColones;
            var laAccion = new Dominio.Acciones.HacerConvertirDolaresColones();
            laConvertirDolaresColones = laAccion.CrearConvertirDolaresColones(dolares, valorColones);
            return laConvertirDolaresColones;
        }
    }
}