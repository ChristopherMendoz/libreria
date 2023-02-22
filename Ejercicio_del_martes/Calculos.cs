using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Calculos
    {
        public double CantidadNueva(double CantidadAnti, double CantidadNuev)
        {
            return CantidadAnti - CantidadNuev;
        }
        public double TotalPrecio(double precio, double cantDispo)
        {

            return precio * cantDispo;
        }
        public double Paago(double pago)
        {
            return pago;
        }
        public double Cambio(double total, double pago)
        {
            return pago - total;
        }
    }
}
