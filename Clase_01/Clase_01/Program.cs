namespace Clase_01
{
    internal class Ejercicio_01
    {
        /* Ingresar 5 números por consola, guardándolos en una variable escalar.
         Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */

        public void Main()
        {
            Console.Title = "Ejercicio Nro 01";


            List<int> numeros = new List<int>();

            while (numeros.Count < 5)
            {
                Console.WriteLine("Ingrese un número mayor a cero:");
                var numeroIngresado = Console.ReadLine();
                int.TryParse(numeroIngresado, out int numero);

                if (numero > 0)
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("ERROR: Número menor a 0.");
                }
            }

            int numeroMayor = 0;
            int numeroMenor = 0;
            float total = 0;

            foreach (int numero in numeros)
                {
                    if (numeroMenor == 0 || numeroMenor > numero)
                {
                    numeroMenor = numero;
                }    

                    if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
                    total += numero;
                }

            float promedio = total / numeros.Count;

            Console.WriteLine("Numero más alto: {0}", numeroMayor);
            Console.WriteLine("Numero más bajo: {0}", numeroMenor);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();
            }
        }
    internal class Ejercicio_02
    {
        /* Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
        Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje:
        "ERROR. ¡Reingresar número!".
        Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. */

        public void Main()
        {
            Console.Title = "Ejercicio Nro 02";

            Console.WriteLine("Ingrese un número mayor a cero:");
            var numeroIngresado = Console.ReadLine();
            int.TryParse(numeroIngresado, out int numero);

            int numeroCuadrado = 0;
            int numeroCubo = 0;

            if(numero > 0)
            {
                numeroCuadrado = (int)Math.Pow(numero, 2);
                numeroCubo = (int)Math.Pow(numero, 3);
            } else
            {
                Console.WriteLine("ERROR: ¡Reingresar número!");
            }

            Console.WriteLine("Número ingresado: {0}", numero);
            Console.WriteLine("Numero potenciado al cuadrado: {0}",numeroCuadrado);
            Console.WriteLine("Numero potenciado al cubo: {0}", numeroCubo);
        }
    }
    internal class Ejercicio_03
    {
        /* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
        por consola.
        Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). */

        public void Main()
        {
            Console.Title = "Ejercicio Nro 03";

            int numeroBuscado = 0;

            while (true)
            {
                Console.WriteLine("Ingrese un número mayor a uno:");
                var numeroIngresado = Console.ReadLine();
                int.TryParse(numeroIngresado, out int numero);

                if (numero <= 1)
                {
                    Console.WriteLine("ERROR: ¡Reingresar número!");
                }
                else
                {
                    numeroBuscado = numero;
                    break;
                } 
            }

            List<int> numeros = new List<int>();

            for (int a = 2; a <= numeroBuscado; a++)
            {
                bool prime = true;
                for (int b = 2; b <= a; b++)
                {
                    if (a != b && a % b == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    numeros.Add(a);
                }
            }

            Console.WriteLine("Numeros primos:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
    internal class Ejercicio_04
    {
        /* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
        (excluido el mismo) que son divisores del número.
        El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        Escribir una aplicación que encuentre los 4 primeros números perfectos.
        Nota: Utilizar estructuras repetitivas y selectivas. */

        public void Main()
        {
            Console.Title = "Ejercicio Nro 04";

            int i = 1;
            List<int> numerosPerfectos = new List<int>();
            List<int> divisores = new List<int>();

            while (numerosPerfectos.Count < 4)
            {
                for(int n = 1; n <= i; n++)
                {
                    if (i != n && i % n == 0)
                    {
                        divisores.Add(n);
                    }
                }
                int total = 0;
                foreach (int numero in divisores)
                {
                    total += numero;
                }
                if (total == i)
                {
                    numerosPerfectos.Add(i);
                }
                divisores.Clear();
                i++;
            }

            Console.WriteLine("Numeros perfectos:");
            foreach (int numero in numerosPerfectos)
            {
                Console.WriteLine(numero);
            }
        }
    }
    internal class Ejercicio_05
    {
        /* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
        dos grupos de números, cuyas sumas son iguales.
        El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
        cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
        49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
        Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
        usuario ingrese por consola.
        Nota: Utilizar estructuras repetitivas y selectivas. */

        public void Main()
        {
            Console.Title = "Ejercicio Nro 05";

            int numeroBuscado = 0;

            while (numeroBuscado == 0)
            {
                Console.WriteLine("Ingrese un número mayor a cero:");
                var numeroIngresado = Console.ReadLine();
                int.TryParse(numeroIngresado, out int numero);

                if (numero > 0)
                {
                    numeroBuscado = numero;
                }
                else
                {
                    Console.WriteLine("ERROR: Número menor a 0.");
                }
            }

            Console.WriteLine("Numeros perfectos:");
            foreach (int numero in numerosPerfectos)
            {
                Console.WriteLine(numero);
            }
        }
    }
    class Test
    {
        static void Main (string[] args)
        {
            Ejercicio_04 test = new Ejercicio_04();
            test.Main ();
        }
    }
    }