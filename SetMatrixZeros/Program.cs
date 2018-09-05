using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMatrixZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            //add size and other validation if required
            int[,] matrix = new int[n, n];
            List<int> row = new List<int>();
            List<int> col = new List<int>();
            int k = 1;
            Console.WriteLine("Enter your values separated by space.");
            for (int i = 0; i < n; i++)
            {                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = k++;
                }
            }
            matrix[2, 2] = 0;
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row.Add(i);
                        col.Add(j);
                    }
                        
                }               
            }

            foreach (var item in row)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[item, i] = 0;
                }
               
            }

            foreach (var item in col)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i,item] = 0;
                }

            }
            Console.WriteLine();
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
