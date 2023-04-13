using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.9;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar((euro.cantidad / Euro.cotizRespectoDolar));
        }
        public static explicit operator Peso(Euro euro)
        {
            return (Peso)((Dolar)euro);
        }
    }
}
