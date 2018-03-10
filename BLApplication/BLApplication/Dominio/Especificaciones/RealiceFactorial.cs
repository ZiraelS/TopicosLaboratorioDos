using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceFactorial
    {
        public double RealizarFactorial(double numero)
        {
            double elFactorial;
            var laAccion = new Dominio.Acciones.HacerFactorial();
            elFactorial = laAccion.CrearFactorial(numero);
            return elFactorial;
        }
    }
}