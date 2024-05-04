namespace Lab2
{
    internal class Program15
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 14:
            // Suma de Dígitos:

            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int sumaDigitos = CalcularSumaDigitos(numero);
            Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");

            int CalcularSumaDigitos(int n)
            {
                int suma = 0;
                while (n != 0)
                {
                    suma += n % 10;
                    n /= 10;
                }
                return suma;
            }
        }
    }
}