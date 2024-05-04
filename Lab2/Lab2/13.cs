namespace Lab2
{
    internal class Program13
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 12:
            // Generador de Tablas de Multiplicar:

            Console.WriteLine("Ingrese el número del cual desea generar la tabla de multiplicar:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar del número {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}