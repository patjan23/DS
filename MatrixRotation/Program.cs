 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //add size and other validation if required
            int[,] matrix = new int[n, n];
            int k = 1;
            Console.WriteLine("Enter your values separated by space.");
            for (int i = 0; i < n; i++)
            {
               // var values = (Console.ReadLine().Split(' '));
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = k++;
                }
            }
            Console.WriteLine( );
            //to write 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i, j].ToString().Length == 2)
                      Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

           
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }

            }

            Console.WriteLine();
            //to write 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j].ToString().Length == 2)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < n/2; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n-1-j];
                    matrix[i, n - 1 - j] = temp;
                }
            }

           

            Console.WriteLine();
            //to write 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j].ToString().Length == 2)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
