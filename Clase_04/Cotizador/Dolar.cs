using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro((dolar.cantidad * Euro.GetCotizacion()));
        }
        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso((dolar.cantidad * Peso.GetCotizacion()));
        }
    }
}
