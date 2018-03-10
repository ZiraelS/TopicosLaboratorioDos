using System;

namespace BLApplication.Dominio.Especificaciones
{
    public class RealiceInteresSimple
    { 
        public double RealizarInteresSimple(double Capital, double TasadeInteres, double Tiempo)
        {
            double elInteresSimple;
            var laAccion = new Dominio.Acciones.HacerInteresSimple();
            elInteresSimple = laAccion.CrearInteresSimple(Capital, TasadeInteres, Tiempo);
            return elInteresSimple;
        }
    }
}