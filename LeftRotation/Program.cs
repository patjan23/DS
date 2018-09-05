using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int k = 2;
         
            int[] a = {1,2,3,4,5,6,7};
            int n = a.Length;

            int[] temp = new int[k];

            for (int i = 0; i < k; i++)
            {
                temp[i] = a[i];
            }

            for (int i = 0; i < n - k; i++)
            {
                a[i] = a[i + k];
            }

            int t = 0;
            for (int i = n-k ; i < n; i++)
            {
                a[i] = temp[t];
                t++;
            }

            //while (k > 0)
            //{
            //    int last_elememt = a[n - 1];
            //    for (int i = n - 1; i >= 0; i--)
            //    {
            //        if (i != 0)
            //            a[i] = a[i - 1];
            //    }
            //    a[0] = last_elememt;
            //    k--;
            //    foreach (int h in a)
            //    {
            //        Console.Write(h + " ");
            //    }
            //    Console.WriteLine();
            //}
            foreach (int h in a)
            {
                Console.Write(h + " ");
            }
            Console.ReadKey();
        }
    }
}
