using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public class Numeros
    {
        public static List<int> EncontrarNumerosPrimos(List<int> numeros)
        {
            List<int> primos = new List<int>();
            foreach (int num in numeros)
            {
                if (EsPrimo(num))
                {
                    primos.Add(num);
                }
            }
            return primos;
        }
        private static bool EsPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
