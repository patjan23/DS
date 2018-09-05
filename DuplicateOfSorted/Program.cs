using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateOfSorted
{
    class Program
    {


        static int removeDuplicates(int[] arr, int n)
        {
            if (n == 0 || n == 1)
                return n;

            // To store index of next unique element
            int j = 0;

            // Doing same as done in Method 1
            // Just maintaining another updated index i.e. j
            for (int i = 0; i < n - 1; i++)
                if (arr[i] != arr[i + 1])
                    arr[j++] = arr[i];

            arr[j++] = arr[n - 1];

            return j;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]  { 1,2,2,5,6,7,7,7,8,9,9};
            // Print updated array
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            int  n = removeDuplicates(arr, arr.Length);

            // Print updated array
            for (int i = 0; i < n; i++)
                Console.Write (arr[i] + " ");
            Console.ReadKey();
        }
    }
}
