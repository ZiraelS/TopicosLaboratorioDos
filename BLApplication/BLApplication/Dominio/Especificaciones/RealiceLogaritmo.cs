using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceLogaritmo
    {
        public double RealizarLogaritmo(double numero)
        {
            double elLogaritmo;
            var laAccion = new Dominio.Acciones.HacerLogaritmo();
            elLogaritmo = laAccion.CrearLogaritmo(numero);
            return elLogaritmo;
        }
    }
}