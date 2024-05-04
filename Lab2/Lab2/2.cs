
Console.WriteLine("Laboratorio 2 Actividades");

// Ejercicio parte 01:
// Verificación de Número Par o Impar::

Console.WriteLine("Ingrese un número para verificar si es par o impar:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"El número {numero} es par.");
}
else
{
    Console.WriteLine($"El número {numero} es impar.");
}
