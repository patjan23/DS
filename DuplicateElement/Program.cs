
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =0;
            int[] arr = new int[] { 3, 1, 2, 3, 4 };
            bool[] b = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (b[arr[i]] != true)
                {
                    //b[arr[i]] 
                        
                    //    true;
                }
                else
                {                   
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
