using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[] { 0,0 };
            
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {                   
                    if (comparenumber(a[i].ToString(),a[j].ToString()))
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }

                }
            }
            string k = string.Empty;

            foreach (var item in a)
            {
                k = item.ToString() + k;
            }
            if (k.Contains("0") && (k.Distinct().Count() == 1))
                k = "0";
                    Console.WriteLine(k);
            Console.ReadKey();

        }

        private static bool comparenumber(string X, string Y)
        {
            string XY = X + Y;

            // then append X at the end of Y
            string YX = Y + X;

            // Now see which of the two formed numbers 
            // is greater
            return XY.CompareTo(YX) > 0 ? false : true;

        }
    }
}
