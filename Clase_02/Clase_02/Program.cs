using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Entidades;
using Microsoft.VisualBasic;

namespace Clase_02
{
    class Ejercicio_00
    {
        //Nombre de la mascota
        //Edad(Validar 1 - 12)
        //Tipo: (Validar “gato”, “perro”, “hamster”)
        //Peso: (Validar 0 - 50)
        //Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

        //Informes:

        //Nombre de la mascota más vieja
        //Cantidad de mascotas con parásitos
        //Nombre, edad y diagnóstico de la mascota más joven ingresada.

        public void Main(string[] args)
        {
            string nombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnostico;

            nombreMascota = Validador.ValidarString("Nombre de la mascota:");
            edadMascota = Validador.ValidarNumero("Edad de la mascota (1 a 12 años):", 1, 12);
            tipoMascota = Validador.ValidarString("Tipo de mascota (gato, perro o hamster):", "gato", "perro", "hamster");
            pesoMascota = Validador.ValidarNumero("Peso de la mascota (0 a 50 kilos):", 0, 50);
            diagnostico = Validador.ValidarString("Diagnóstico (otitis, alergias, parasitos):", "otitis", "alergias", "parasitos");
        }
    }

    class Ejercicio_11
    {
        //Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la siguiente firma:
        //bool Validar(int valor, int min, int max):
        //a.valor: dato a validar
        //b.min y max: rango en el cual deberá estar la variable valor.
        //Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango
        //-100 y 100.
        //Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
        //Nota: Utilizar variables escalares, NO utilizar vectores.
        public void Main()
        {
            int numeroMin = 0;
            int numeroMax = 0;
            float total = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese diez números entre -100 y 100:");

            for (int i = 0; i < 10; i++)
            {
                int.TryParse(Console.ReadLine(), out int numero);
                if (Validador.Validar(numero, -100, 100))
                {
                    if (numero > numeroMax)
                    {
                        numeroMax = numero;
                    }
                    if (numeroMin == 0 || numero < numeroMin)
                    {
                        numeroMin = numero;
                    }
                    total += numero;
                }
                else
                {
                    Console.WriteLine("ERROR: Número inválido.");
                    i--;
                }
            }
            promedio = total / 10;

            Console.WriteLine("Valor mínimo: {0}", numeroMin);
            Console.WriteLine("Valor máximo: {0}", numeroMax);
            Console.WriteLine("Promedio: {0}", promedio);
        }
    }

    class CalculadoraDeArea
    {
        public double CalcularAreaCuadrado(double longitudLado)
        {
            double area = longitudLado * longitudLado;
            return area;
        }
        public double CalcularAreaTriangulo(double cbase, double altura)
        {
            double area = (cbase * altura) / 2;
            return area;
        }
        public double CalcularAreaCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        public void Main()
        {
            string tipo;
            double area = 0;
  
            tipo = Validador.ValidarString("Tipo de forma (cuadrado, triangulo, ciculo):", "cuadrado", "triangulo", "circulo");

            switch (tipo)
            {
                case "cuadrado":
                    Console.WriteLine("Ingresar longitud de lados:");
                    double.TryParse(Console.ReadLine(), out double lado);
                    area = CalcularAreaCuadrado(lado);
                    break;
                case "triangulo":
                    Console.WriteLine("Ingresar base:");
                    double.TryParse(Console.ReadLine(), out double cbase);
                    Console.WriteLine("Ingresar altura:");
                    double.TryParse(Console.ReadLine(), out double altura);
                    area = CalcularAreaTriangulo(cbase,altura);
                    break;
                case "circulo":
                    Console.WriteLine("Ingresar radio:");
                    double.TryParse(Console.ReadLine(), out double radio);
                    area = CalcularAreaCirculo(radio);
                    break;
            }

            Console.WriteLine("Área del {0}: {1}", tipo, area);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            CalculadoraDeArea testing = new CalculadoraDeArea();
            testing.Main();
        }
    }
}