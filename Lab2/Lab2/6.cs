namespace Lab2
{
    internal class Program6
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 05:
            // Inversión de Cadena:

            Console.WriteLine("Ingrese una cadena de texto:");
            string texto = Console.ReadLine();

            string textoInvertido = InvertirCadena(texto);
            Console.WriteLine($"La cadena invertida es: {textoInvertido}");

            string InvertirCadena(string cadena)
            {
                char[] caracteres = cadena.ToCharArray();
                Array.Reverse(caracteres);
                return new string(caracteres);
            }
        }
    }
}