namespace Lab2
{
    internal class Program9
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 2 Actividades");

            // Ejercicio parte 08:
            // Contador de Vocales:

            Console.WriteLine("Ingrese una cadena de texto:");
            string texto = Console.ReadLine();

            int contadorVocales = ContarVocales(texto);
            Console.WriteLine($"El número de vocales en la cadena es: {contadorVocales}");

            int ContarVocales(string cadena)
            {
                int contador = 0;
                foreach (char caracter in cadena)
                {
                    if (EsVocal(caracter))
                    {
                        contador++;
                    }
                }
                return contador;
            }

            bool EsVocal(char caracter)
            {
                char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                return Array.Exists(vocales, vocal => vocal == caracter);
            }
        }
    }
}