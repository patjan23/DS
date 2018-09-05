using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 };
            int n = arr.Length;
            int maxDiff = maxIndexDiff(arr, n);
            Console.WriteLine(maxDiff);
            Console.ReadKey();
        }
       static private int maxIndexDiff(int[] arr, int n)
        {
            int maxDiff = -1;
            int i, j;

            for (i = 0; i < n; ++i)
            {
                for (j = n - 1; j > i; --j)
                {
                    if (arr[j] > arr[i] && maxDiff < (j - i))
                    {
                        maxDiff = j - i;
                        Console.WriteLine( j +"  "+ i );
                    }
                }
            }

            return maxDiff;
        }
    }
}
