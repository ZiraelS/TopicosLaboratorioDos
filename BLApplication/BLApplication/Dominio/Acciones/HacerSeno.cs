using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerSeno
    {
        public double CrearSeno(double grados)
        {
            double angulo = Math.PI * grados / 180.0;
            return Math.Sin(angulo);
        }
    }
}