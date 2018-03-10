using System;

namespace BLApplication.Dominio.Acciones
{
    public class HacerConvertirDolaresColones
    {
        public double CrearConvertirDolaresColones(double dolares, double valorColones)
        {
            if (dolares > 0 && valorColones > 0)
            {
                return dolares * valorColones;
            }
            return 0;
        }
    }
}