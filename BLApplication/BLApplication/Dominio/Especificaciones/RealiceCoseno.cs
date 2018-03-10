using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceCoseno
    {
        public double RealizarCoseno(double grados)
        {
            double elCos;
            var laAccion = new Dominio.Acciones.HacerCoseno();
            elCos = laAccion.CrearCoseno(grados);
            return elCos;
        }
    }
}