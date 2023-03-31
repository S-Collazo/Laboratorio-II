namespace Entidades
{
    public class Validador
    {
        public static bool Validar (int valor, int min, int max)
        {
            bool valido = false;
            if (valor > min && valor < max)
            {
                valido = true;
            }
            return valido;
        }
        public static int ValidarNumero(string mensaje, int min, int max)
        {
            Console.WriteLine(mensaje);
            int.TryParse(Console.ReadLine(), out int numero);

            while (numero < min || numero > max)
            {
                Console.WriteLine("ERROR: Valor incorrecto. Ingrese un valor entre {0} y {1}", min, max);
                int.TryParse(Console.ReadLine(), out numero);
            }
            return numero;
        }
        public static string ValidarString(string mensaje, params string[] tipos)
        {
            Console.WriteLine(mensaje);
            string texto = Console.ReadLine();

            while (tipos.Length > 0 && !(tipos.Contains(texto)))
            {
                Console.WriteLine("ERROR: Dato incorrecto.");
                Console.WriteLine(mensaje);
                texto = Console.ReadLine();
            }
            return texto;
        }
    }
}