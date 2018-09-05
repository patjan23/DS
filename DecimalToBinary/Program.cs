using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string k = Converion(n);
            Console.WriteLine(CountHighestZero(k));
        }

        private static int CountHighestZero(string k)
        {
            int Count = 0, prevCount = 0,curCount = 0;
            for (int i = 1; i < k.Length; i++)
            {
                if (k[i] == '0')
                    Count++;
                else
                {
                    curCount = Count;
                    if (prevCount < curCount)
                    {
                        prevCount = curCount;
                        curCount = 0;
                    }
                    Count = 0;
                }
            }
            return prevCount == 0 ? curCount : prevCount;
        }

        public static string Converion(int k1)
        {
            int q = k1;
            string r = ""; 
            while (q != 0)
            {
                r =  (q % 2).ToString()+ r ;
                q = q / 2;
            }
            Console.WriteLine(r);
            return r;
        }
    }
}
