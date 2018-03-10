using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceSeno
    {
        public double RealizarSeno(double grados)
        {
            double elSen;
            var laAccion = new Dominio.Acciones.HacerSeno();
            elSen = laAccion.CrearSeno(grados);
            return elSen;
        }
    }
}