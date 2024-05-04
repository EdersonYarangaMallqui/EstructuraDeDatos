namespace Lab2
{
    internal class Program4
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 03:
            // Área de un Triángulo:

            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");

            double CalcularAreaTriangulo(double b, double h)
            {
                return b * h / 2;
            }
        }
    }
}