namespace Lab2
{
    internal class Program2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 01:
            // Operaciones Básicas:

            Console.WriteLine("Ingresa primer número: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa segundo número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());
            var suma = num1 + num2;
            var resta = num1 - num2;
            var multiplicacion = num1 * num2;
            var division = num1 / num2;

            Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
            Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
            Console.WriteLine($"División: {num1} / {num2} = {division}");
        }
    }
}