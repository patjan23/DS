using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n0 = 5;

            for (int i = 1; i <= n0; i++)
            {
                int n = Fact(i);
                for (int j = 0; j < i; j++)
                {
                    int r = Fact(j);
                    int nr = Fact(i-j);
                    int result = n / (r * nr);
                    Console.Write(result + "   " );
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static int Fact(int number)
        {
            int product = 1;
            for (int i = 1; i < number; i++)
            {
                product = product * i;
            }
            return product;
        }
    }
}
