namespace Lab2
{
    internal class Program8
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 07:
            // Lista de Cuadrados:

            List<int> cuadrados = ObtenerCuadradosPrimerosDiez();
            Console.WriteLine("Lista de los cuadrados de los primeros 10 números naturales:");
            foreach (int cuadrado in cuadrados)
            {
                Console.WriteLine(cuadrado);
            }

            List<int> ObtenerCuadradosPrimerosDiez()
            {
                List<int> resultado = new List<int>();
                for (int i = 1; i <= 10; i++)
                {
                    resultado.Add(i * i);
                }
                return resultado;
            }
        }
    }
}