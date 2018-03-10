using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceTangente
    {
        public double RealizarTangente(double grados)
        {
            double laTan;
            var laAccion = new Dominio.Acciones.HacerTangente();
            laTan = laAccion.CrearTangente(grados);
            return laTan;
        }
    }
}