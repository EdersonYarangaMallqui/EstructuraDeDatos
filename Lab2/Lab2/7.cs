namespace Lab2
{
    internal class Program7
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 06:
            // Suma de Números Pares:

            Console.WriteLine("Ingrese el número inicial del rango:");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número final del rango:");
            int fin = Convert.ToInt32(Console.ReadLine());

            int sumaPares = CalcularSumaPares(inicio, fin);
            Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");

            int CalcularSumaPares(int inicio, int fin)
            {
                int suma = 0;
                for (int i = inicio; i <= fin; i++)
                {
                    if (i % 2 == 0)
                    {
                        suma += i;
                    }
                }
                return suma;
            }
        }
    }
}