namespace Lab2
{
    internal class Program10
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 09:
            // Números de la Serie Fibonacci:

            List<int> fibonacci = GenerarFibonacci(10);
            Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
            foreach (int numero in fibonacci)
            {
                Console.WriteLine(numero);
            }

            List<int> GenerarFibonacci(int cantidad)
            {
                List<int> resultado = new List<int>();
                int a = 0;
                int b = 1;
                for (int i = 0; i < cantidad; i++)
                {
                    resultado.Add(a);
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return resultado;
            }
        }
    }
}