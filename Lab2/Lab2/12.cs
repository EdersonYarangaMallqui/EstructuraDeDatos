namespace Lab2
{
    internal class Program12
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 11:
            // Palíndromo:

            Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:");
            string palabra = Console.ReadLine();

            bool esPalindromo = VerificarPalindromo(palabra);

            if (esPalindromo)
            {
                Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
            }

            bool VerificarPalindromo(string texto)
            {
                texto = texto.ToLower(); // Convertir la palabra a minúsculas para hacer la comparación sin distinción de mayúsculas y minúsculas.
                int i = 0;
                int j = texto.Length - 1;
                while (i < j)
                {
                    if (texto[i] != texto[j])
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
                return true;
            }
        }
    }
}