using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerCoseno
    {
        public double CrearCoseno(double grados)
        {
            double angulo = Math.PI * grados / 180.0;
            return Math.Cos(angulo);
        }
    }
}