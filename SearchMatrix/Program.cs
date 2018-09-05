using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix size : ");
            int num = Convert.ToInt32(Console.ReadLine());
            //add size and other validation if required
            int[,] matrix = new int[num, num];
            int k = 0;
            Console.WriteLine("Enter your values separated by space.");
            for (int i = 0; i < num; i++)
            {
                // var values = (Console.ReadLine().Split(' '));
                for (int j = 0; j < num; j++)
                {
                    matrix[i, j] = k++;
                }
            }
            Console.WriteLine();
            //to write 
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (matrix[i, j].ToString().Length == 2)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }



            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int target = 15; 
            int start = 0;
            int end = m * n - 1;
            bool result = false; 
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int midX = mid / n;
                int midY = mid % n;

                if (matrix[midX, midY] == target)
                {
                    result = true;
                    break;// remove it
                }
                if (matrix[midX,midY] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            result = false;
        }
    }
}
