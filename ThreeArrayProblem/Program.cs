using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeArrayProblem
{
    class Program
    {
        static int N = 3;
        static void Main(string[] args)
        {
            // TODO Auto-generated method stub
          
            int[] A = {10, 29, 50 };
            Array.Sort(A); ;

            int[] B = {30, 61, 37 };
            Array.Sort(B);

            int[] C = { 100,37, 70 };
            Array.Sort(C);
            
            int[] possibilitiesFromBtoC = findPossibilitiesBetweenTwoArrays(B, C);
            int[] cumulativeSums = findCumulativeSum(possibilitiesFromBtoC);
            int[] finalPossibilities = new int[N];

            for (int i = 0; i < N; i++)
            {
                int postionInSecondArray = findNextGreaterElementPos(A[i], B);
                finalPossibilities[i] = cumulativeSums[postionInSecondArray];
            }

            int output = 0;
            for (int i = 0; i < N; i++)
            {
                output += finalPossibilities[i];
            }

           Console.WriteLine("final possibilities are :" + output);
            }

        private static int[] findCumulativeSum(int[] relativePossibilities)
        {

            int[] output = new int[N];
            output[N - 1] = relativePossibilities[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                output[i] = relativePossibilities[i] + relativePossibilities[i + 1];
            }
            return output;
        }

        private static int[] findPossibilitiesBetweenTwoArrays(int[] A, int[] B)
        {
            int[] relativePossibilities = new int[N];

            for (int i = 0; i < N; i++)
            {
                int postionInSecondArray = findNextGreaterElementPos(A[i], B);
                relativePossibilities[i] = (N - postionInSecondArray);
            }

            return relativePossibilities;
        }

        private static int findNextGreaterElementPos(int element, int[] sortedArray)
        {
            int low = 0;
            int high = N;
            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                if (sortedArray[mid] < element)
                    low = mid + 1;
                else if (sortedArray[mid] > element)
                    high = mid - 1;
                else
                    return mid + 1;
            }

            if (high < 0)
                return 0;
            else
            if (low > (N - 1))
                return N;
            else
                return (low < high)
                    ? low + 1
                    : high + 1;

        }
    }
}
