using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrappingRainWater
{
    class Program
    {
        static int[] arr = new int[] { 3, 0, 0, 2, 0, 4 };
        static int findWater(int n)
        {
            // left[i] contains height of tallest bar to the
            // left of i'th bar including itself
            int[] left = new int[n];

            // Right [i] contains height of tallest bar to
            // the right of ith bar including itself
            int[] right = new int[n];

            // Initialize result
            int water = 0;

            // Fill left array
            left[0] = arr[0];
            for (int i = 1; i < n; i++)
                left[i] = Math.Max(left[i - 1], arr[i]);

            // Fill right array
            right[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
                right[i] = Math.Max(right[i + 1], arr[i]);

            // Calculate the accumulated water element by element
            // consider the amount of water on i'th bar, the
            // amount of water accumulated on this particular
            // bar will be equal to min(left[i], right[i]) - arr[i] .
            for (int i = 0; i < n; i++)
                water += Math.Min(left[i], right[i]) - arr[i];

            return water;
         }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum water that can be accumulated is " +
                                        findWater(arr.Length));
        }
    }
}
