namespace Lab2
{
    internal class Program14
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 13:
            // Cálculo del Área de un Círculo:

            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaCirculo(radio);
            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

            double CalcularAreaCirculo(double r)
            {
                return Math.PI * Math.Pow(r, 2);
            }
        }
    }
}