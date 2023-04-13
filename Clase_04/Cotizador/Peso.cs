using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 398;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }
        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar((peso.cantidad / Peso.cotizRespectoDolar));
        }
        public static explicit operator Euro(Peso peso)
        {
            return (Euro)((Dolar)peso);
        }
    }
}