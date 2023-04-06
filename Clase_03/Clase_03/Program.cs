using Boligrafo;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo.Boligrafo bolAzul = new Boligrafo.Boligrafo(100, ConsoleColor.Blue);
            Boligrafo.Boligrafo bolRojo = new Boligrafo.Boligrafo(50, ConsoleColor.Red);
            Boligrafo.Boligrafo bolVerde = new Boligrafo.Boligrafo(10, ConsoleColor.Green);

            string dibujo;

            bolAzul.Pintar(-80, out dibujo);
            bolRojo.Pintar(-45, out dibujo);
            bolVerde.Pintar(-20, out dibujo);
        }
    }
}

namespace Boligrafo
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            this.tinta = (short)(this.tinta + tinta);
            if (this.tinta >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else if (this.tinta <= 0)
            {
                this.tinta = 0;
            }
        }
        public void Recargar()
        {
            SetTinta(Boligrafo.cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            Console.ForegroundColor = this.color;
            bool estadoTinta = false;

            SetTinta(gasto);

            if (this.tinta > 0)
            {
                dibujo = "Se pudo pintar. Tinta restante: ";
                for (int i = 0; i < this.tinta; i++)
                {
                    dibujo += "*";
                }
                estadoTinta = true;
            }
            else
            {
                dibujo = "No se pudo pintar";
            }
            Console.WriteLine(dibujo);
            return estadoTinta;
        }
    }
}