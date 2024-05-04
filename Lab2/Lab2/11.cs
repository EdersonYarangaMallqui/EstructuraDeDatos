namespace Lab2
{
    internal class Program11
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 10:
            // Ordenamiento de Lista:

            Console.WriteLine("Ingrese la cantidad de números que desea ordenar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            List<int> numeros = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
            }

            numeros.Sort();

            Console.WriteLine("Lista ordenada de menor a mayor:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}