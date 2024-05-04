namespace Lab2
{
    internal class Program5
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 04:
            // Número Primo:

            Console.WriteLine("Ingrese un número para verificar si es primo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool esPrimo = VerificarPrimo(numero);
            if (esPrimo)
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }

            bool VerificarPrimo(int n)
            {
                if (n <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}