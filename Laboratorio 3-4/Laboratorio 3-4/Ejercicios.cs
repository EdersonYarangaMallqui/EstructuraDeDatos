using System;

namespace Laboratorio3y4
{
    public class Ejercicios
    {
        public void ImprimirParesRecursivo(int numero = 1)
        {            
            if(numero > 100) { 
                return;
            }
            if(numero%2 == 0)
            {
                Console.WriteLine(numero);
            }
            ImprimirParesRecursivo(numero + 1);
        }
    }

    public class Ejercicio2
    {
        public int SumaRecursiva(int n)
        {
            // Caso base: si n es igual a 1, retorna 1
            if (n == 1)
            {
                return 1;
            }
           
            // Caso recursivo: suma n y el resultado de la llamada recursiva con n-1
           else {
                return n + SumaRecursiva(n-1);
            }
        }
    }
    public class Ejercicio3
    {
        public void ImprimirPiramideRecursiva(int n, int fila = 1)
        {
            //Caso base: si la fila es mayor que n, termina la recursión
            if (fila > n)
                return;

            //Imprimir los números de 1 a fila
            for (int i = 1; i <= fila; i++)
            {
                Console.Write(fila + " ");
            }
            Console.WriteLine();

            //Llamada recursiva a la siguiente fila
            ImprimirPiramideRecursiva(n, fila + 1);
        }
    }
    public class Ejercicio4
    {
        public void ImprimirPiramideInvertidaRecursiva(int n, int fila = 1)
        {
            //Caso base: si la fila es mayor que n, termina la recursión
            if (fila > n)
                return;

            //Imprimimos espacios en blanco para alinear los números
            for (int i = 0; i <= n - fila; i++)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine(" ");

            //Llamada recursiva con la siguiente fila
            ImprimirPiramideInvertidaRecursiva(n-1);
        }
    }
    
    public class Ejercicio5
    {
        public void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
        {
            if (multiplicador > 12)
                return;

            Console.WriteLine(n + " x " + multiplicador + " = " + n * multiplicador);
            ImprimirTablaMultiplicar(n, multiplicador+1);
        }
    }
    public class Ejercicio6
    {
        public void CrearMatrizReales(int filas, int columnas)
        {
            double[,] Matriz = new double[filas,columnas];
            Console.WriteLine("Ingrese los datos para la matriz: ");
            for (int i = 1; i<= filas; i++)
            {
                for (int j = 1; j<= columnas; j++)
                {
                    Console.WriteLine("Ingrese numero correspondiente a la matriz[i,j]" 
                        + "-> i= "+i + " j= "+j);
                    Matriz[i-1,j-1] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Los elementos de la matriz son: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Ejercicio7
    {
        public struct NumeroComplejo
        {
            public double Real;
            public double Imaginario;
            public NumeroComplejo(double real, double imaginario)
            {
                Real = real;
                Imaginario = imaginario;
            }

            // Imprimir un número complejo
            public override string ToString()
            {
                return Real + " + " + Imaginario + "i";
            }
        }
        public void CrearMatrizComplejos(int filas, int columnas)
        {
            NumeroComplejo[,] matriz = new NumeroComplejo[filas, columnas];

                Console.WriteLine("Ingrese los datos para la matriz: ");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.WriteLine("Ingrese la parte real del número complejo [" + (i + 1) + "," + (j + 1) + "]:");
                        double real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del número complejo [" + (i + 1) + "," + (j + 1) + "]:");
                        double imaginario = Convert.ToDouble(Console.ReadLine());

                        matriz[i, j] = new NumeroComplejo(real, imaginario);
                    }
                }

                Console.WriteLine("Los elementos de la matriz son: ");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    
    public class Ejercicio8
    {
        public void CrearMatrizDeMatrices(int filas, int columnas)
        {
            int[][][] matrizDeMatrices = new int[filas][][];

            for (int i = 0; i < filas; i++)
            {
                // Definir la submatriz con un número aleatorio de columnas
                int numColumnas = new Random().Next(1, columnas + 1);
                matrizDeMatrices[i] = new int[numColumnas][];

                // Llenar la submatriz con valores aleatorios
                for (int j = 0; j < numColumnas; j++)
                {
                    int numElementos = new Random().Next(1, columnas + 1);
                    matrizDeMatrices[i][j] = new int[numElementos];
                    for (int k = 0; k < numElementos; k++)
                    {
                        matrizDeMatrices[i][j][k] = new Random().Next(1, 101); // Valores aleatorios entre 1 y 100
                    }
                }
            }
            // Imprimir la matriz de matrices
            Console.WriteLine("Matriz de matrices:");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Fila " + (i + 1) + ":");
                for (int j = 0; j < matrizDeMatrices[i].Length; j++)
                {
                    Console.WriteLine("  Submatriz " + (j + 1) + ":");
                    for (int k = 0; k < matrizDeMatrices[i][j].Length; k++)
                    {
                        Console.Write(matrizDeMatrices[i][j][k] + " ");
                    }
                    Console.WriteLine(); // Nueva línea después de cada submatriz
                }
                Console.WriteLine();
            }
        }
    }
    public class Ejercicio9
    {
        public int? ObtenerElementoCentral(int[,] matriz)
        {
            // Obtener el número de filas y columnas de la matriz
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Verificar si la matriz tiene un número impar de filas y columnas
            if (filas % 2 != 0 && columnas % 2 != 0)
            {
                int filaCentral = filas / 2;
                int columnaCentral = columnas / 2;
                return matriz[filaCentral, columnaCentral];
            }
            else
            {
                // Si la matriz tiene un número par de filas o columnas,
                // no hay un elemento central único
                return null;
            }
        }
    }
    public class Ejercicio10
    {
        public int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
        {
            // Obteniendo las dimensiones de ambas matrices
            int filasMatriz1 = matriz1.GetLength(0);
            int columnasMatriz1 = matriz1.GetLength(1);
            int filasMatriz2 = matriz2.GetLength(0);
            int columnasMatriz2 = matriz2.GetLength(1);

            // Verificando si las matrices tienen las mismas dimensiones
            if (filasMatriz1 != filasMatriz2 || columnasMatriz1 != columnasMatriz2)
            {
                Console.WriteLine("No se pueden sumar matrices de diferentes tamaños.");
                return null;
            }

            // Crear una matriz para almacenar la suma
            int[,] matrizSuma = new int[filasMatriz1, columnasMatriz1];

            // Sumar los elementos correspondientes de ambas matrices
            for (int i = 0; i < filasMatriz1; i++)
            {
                for (int j = 0; j < columnasMatriz1; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return matrizSuma;
        }
    }
    public class Ejercicio11
    {
        public void MultiplicarMatrizPorNumero()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese el número por el cual desea multiplicar la matriz:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] *= numero;
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    public class Ejercicio12
    {
        public void CalcularMediaMatriz()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Calcular la suma de los elementos de la matriz
            int suma = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }

            // Calcular la media de los elementos de la matriz
            double media = (double)suma / (filas * columnas);
            Console.WriteLine("La media de los elementos de la matriz es: " + media);
        }
    }
    public class Ejercicio13
    {
        public void CrearMatrizAleatoria()
        {
            int[,] matriz = new int[100, 100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    matriz[i, j] = random.Next(100); // Números aleatorios entre 0 y 99
                }
            }

            Console.WriteLine("Matriz de números aleatorios de tamaño 100x100:");
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    public class Ejercicio14
    {
        public void CalcularEstadisticasMatriz()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Calcular la media de los elementos de la matriz
            double media = matriz.Cast<int>().Average();

            // Calcular la mediana de los elementos de la matriz
            int[] elementosOrdenados = matriz.Cast<int>().OrderBy(x => x).ToArray();
            double mediana;
            if (elementosOrdenados.Length % 2 == 0)
            {
                mediana = (elementosOrdenados[elementosOrdenados.Length / 2 - 1] + elementosOrdenados[elementosOrdenados.Length / 2]) / 2.0;
            }
            else
            {
                mediana = elementosOrdenados[elementosOrdenados.Length / 2];
            }

            // Calcular la desviación estándar de los elementos de la matriz
            double desviacionEstandar = Math.Sqrt(matriz.Cast<int>().Select(x => Math.Pow(x - media, 2)).Sum() / (filas * columnas));

            // Imprimir las estadísticas de la matriz
            Console.WriteLine("Estadísticas de la matriz:");
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Mediana: " + mediana);
            Console.WriteLine("Desviación estándar: " + desviacionEstandar);
        }
    }
    public class Ejercicio15
    {
        public void EncontrarElementoMaximo()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Encontrar el elemento máximo de la matriz
            int maximo = matriz[0, 0];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
        }
    }
    public class Ejercicio16
    {
        public void EncontrarSubmatrizMayorSuma()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Encontrar la submatriz de mayor suma
            int maxSuma = int.MinValue;
            int filaInicio = 0, filaFin = 0, colInicio = 0, colFin = 0;

            for (int i = 0; i < filas; i++)
            {
                int[] sumaTemporal = new int[columnas];
                for (int j = i; j < filas; j++)
                {
                    for (int k = 0; k < columnas; k++)
                    {
                        sumaTemporal[k] += matriz[j, k];
                    }
                    int inicio = 0, maxActual = sumaTemporal[0], maxGlobal = sumaTemporal[0];
                    for (int k = 1; k < columnas; k++)
                    {
                        if (sumaTemporal[k] > sumaTemporal[k] + maxActual)
                        {
                            inicio = k;
                            maxActual = sumaTemporal[k];
                        }
                        else
                        {
                            maxActual += sumaTemporal[k];
                        }
                        if (maxActual > maxGlobal)
                        {
                            maxGlobal = maxActual;
                            colInicio = inicio;
                            colFin = k;
                            filaInicio = i;
                            filaFin = j;
                        }
                    }
                }
            }
            Console.WriteLine("La submatriz de mayor suma es:");
            for (int i = filaInicio; i <= filaFin; i++)
            {
                for (int j = colInicio; j <= colFin; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La suma total de la submatriz es: " + maxSuma);
        }
    }
    public class Ejercicio17
    {
        public void EncontrarMatrizCovarianza()
        {
            Console.WriteLine("Ingrese el número de filas de las matrices:");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de las matrices:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            double[,] matriz1 = new double[filas, columnas];
            double[,] matriz2 = new double[filas, columnas];

            // Solicitar al usuario que ingrese los elementos de la primera matriz
            Console.WriteLine("Ingrese los elementos de la primera matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "] de la primera matriz:");
                    matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Solicitar al usuario que ingrese los elementos de la segunda matriz
            Console.WriteLine("Ingrese los elementos de la segunda matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el elemento [" + (i + 1) + "," + (j + 1) + "] de la segunda matriz:");
                    matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Calcular la matriz de covarianza
            double[,] matrizCovarianza = new double[columnas, columnas];
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double covarianza = 0;
                    for (int k = 0; k < filas; k++)
                    {
                        covarianza += (matriz1[k, i] - CalcularMedia(matriz1, i)) * (matriz2[k, j] - CalcularMedia(matriz2, j));
                    }
                    matrizCovarianza[i, j] = covarianza / filas;
                }
            }
            // Imprimir la matriz de covarianza
            Console.WriteLine("Matriz de covarianza:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizCovarianza[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // Calcular la media de una columna de la matriz
        private double CalcularMedia(double[,] matriz, int columna)
        {
            double suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma += matriz[i, columna];
            }
            return suma / matriz.GetLength(0);
        }
    }
}


