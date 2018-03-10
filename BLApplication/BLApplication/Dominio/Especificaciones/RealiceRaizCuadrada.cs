using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceRaizCuadrada
    {
        public double RealizarCuadrada(double numero)
        {
            double laRaizCuadrada;
            var laAccion = new Dominio.Acciones.HacerRaizCuadrada();
            laRaizCuadrada = laAccion.CrearRaizCuadrada(numero);
            return laRaizCuadrada;
        }
    }
}