using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerTangente
    {
        public double CrearTangente(double grados)
        {
            double angulo = Math.PI * grados / 180.0;
            return Math.Tan(angulo);
        }
    }
}