

using System;

namespace Laboratorio3y4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LABORATORIO DE ESTRUCTURA DE DATOS");
            Console.WriteLine("EJERCICIOS DE RECURSIVIDAD Y ARREGLOS");
            Console.WriteLine("");
            Console.WriteLine("Ingrese número de Ejercicio: ");
            var eleccion = Convert.ToInt32(Console.ReadLine());

            if (eleccion == 1)
            {
                Console.WriteLine("Se muestran los números pares del 1 al 100");
                Ejercicios ejercicio1 = new Ejercicios();
                ejercicio1.ImprimirParesRecursivo();
            }
            else if (eleccion == 2)
            {
                Console.WriteLine("Se muestran la suma de los números desde el 1" +
                    " hasta el número ingresado");
                Ejercicio2 ejercicio2 = new Ejercicio2();
                Console.WriteLine("Ingrese el límite de los números a sumar: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int suma = ejercicio2.SumaRecursiva(n);
                Console.WriteLine("La suma de los " + n + " primeros números es: " + suma);
            }
            else if (eleccion == 3)
            {
                Console.WriteLine("Se muestran la piramide de los 'n' primeros números"); 
                Ejercicio3 ejercicio3 = new Ejercicio3();
                Console.WriteLine("Ingrese el límite de los números:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La pirámide de números del 1 al " + n + " se muestra:");
                ejercicio3.ImprimirPiramideRecursiva(n);

            }
            else if (eleccion == 4)
            {
                Console.WriteLine("Se muestran la piramide invertida de los 'n' primeros números");
                Ejercicio4 ejercicio4 = new Ejercicio4();
                Console.WriteLine("Ingrese un número: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La pirámide de números invertidos del 1 al " + n + "se muestra: ");
                ejercicio4.ImprimirPiramideInvertidaRecursiva(n);
            }
            else if (eleccion == 5)
            {
                Ejercicio5 ejercicio5= new Ejercicio5();
                Console.WriteLine("Ingrese el número a multiplicar: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Se muestra la tabla de multiplicar del número 'n': ");
                ejercicio5.ImprimirTablaMultiplicar(n);
            }
            else if(eleccion == 6)
            {
                Ejercicio6 ejercicio6= new Ejercicio6();
                Console.WriteLine("Creación de Matriz con números reales");
                Console.WriteLine("Ingrese número de filas: ");
                int filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese número de columnas: ");
                int columnas = Convert.ToInt32(Console.ReadLine());

                ejercicio6.CrearMatrizReales(filas, columnas);

            }
            else if (eleccion == 7)
            {
                Console.WriteLine("CREACIÓN DE MATRIZ DE NÚMEROS COMPLEJOS");
                var ejercicio7 = new Ejercicio7();
                Console.WriteLine("Ingrese el número de filas:");
                int filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de columnas:");
                int columnas = Convert.ToInt32(Console.ReadLine());
                ejercicio7.CrearMatrizComplejos(filas, columnas);
            }
            else if (eleccion == 8)
            {
                Console.WriteLine("CREACIÓN DE MATRIZ DE MATRICES CON DATOS ALEATORIOS");
                Ejercicio8 ejercicio8 = new Ejercicio8();
                Console.WriteLine("Ingrese el número de filas:");
                int filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de columnas:");
                int columnas = Convert.ToInt32(Console.ReadLine());
                ejercicio8.CrearMatrizDeMatrices(filas, columnas);
            }
            else if (eleccion == 9)
            {
                Console.WriteLine("Acceder al elemento central de la matriz 3x3 [[2,3,4];[5,6,7];[8,9,10]]");
                int[,] matriz = {{ 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10 }};
                Ejercicio9 ejercicio9 = new Ejercicio9();
                var Central = ejercicio9.ObtenerElementoCentral(matriz);
                Console.WriteLine("El elemento central es:  "+Central.ToString());
            }
            else if (eleccion == 10)
            {
                Console.WriteLine("Sumar dos matrices de diferentes tamaños ");
                Console.WriteLine("Ingrese el número de filas para la primera matriz:");
                int filasMatriz1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de columnas para la primera matriz:");
                int columnasMatriz1 = Convert.ToInt32(Console.ReadLine());

                // Leer la primera matriz desde la consola
                int[,] matriz1 = new int[filasMatriz1, columnasMatriz1];
                Console.WriteLine("Ingrese los elementos de la primera matriz:");
                for (int i = 0; i < filasMatriz1; i++)
                {
                    for (int j = 0; j < columnasMatriz1; j++)
                    {
                        Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                        matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Ingrese el número de filas para la segunda matriz:");
                int filasMatriz2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de columnas para la segunda matriz:");
                int columnasMatriz2 = Convert.ToInt32(Console.ReadLine());

                // Leer la segunda matriz desde la consola
                int[,] matriz2 = new int[filasMatriz2, columnasMatriz2];
                Console.WriteLine("Ingrese los elementos de la segunda matriz:");
                for (int i = 0; i < filasMatriz2; i++)
                {
                    for (int j = 0; j < columnasMatriz2; j++)
                    {
                        Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                        matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Ejercicio10 ejercicio10 = new Ejercicio10();
                int[,] matriz_suma =  ejercicio10.SumarMatrices(matriz1, matriz2);
                Console.WriteLine("La matriz suma es: ");
                for (int i = 0; i < matriz_suma.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz_suma.GetLength(1); j++)
                    {
                        Console.Write(matriz_suma[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else if (eleccion == 11)
            {
                Console.WriteLine("MULTIPLICAR MATRIZ POR UN NÚMERO");
                Ejercicio11 ejercicio11 = new Ejercicio11();
                ejercicio11.MultiplicarMatrizPorNumero();
            }
            else if (eleccion == 12)
            {
                Console.WriteLine("CALCULAR LA MEDIA DE UNA MATRIZ");
                Ejercicio12 ejercicio12 = new Ejercicio12();
                ejercicio12.CalcularMediaMatriz();
            }
            else if (eleccion == 13)
            {
                Ejercicio13 ejercicio13 = new Ejercicio13();
                ejercicio13.CrearMatrizAleatoria();
            }
            else if (eleccion == 14)
            {
                Ejercicio14 ejercicio14 = new Ejercicio14();
                ejercicio14.CalcularEstadisticasMatriz();

            }
            else if (eleccion == 15)
            {
                Ejercicio15 ejercicio15 = new Ejercicio15();
                ejercicio15.EncontrarElementoMaximo();
            }
            else if (eleccion == 16)
            {
                Ejercicio16 ejercicio16 = new Ejercicio16();
                ejercicio16.EncontrarSubmatrizMayorSuma();
            }
            else if (eleccion == 17)
            {
                Ejercicio17 ejercicio17 = new Ejercicio17();
                ejercicio17.EncontrarMatrizCovarianza();
            }
        }
    }
}


