using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix size : ");

            //add size and other validation if required
            //  int[,] matrix = new int[,]();// ; { { 2, 5 }, { 8, 4 }, { 0, -1 } };
            int p = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[p, p];// ; { { 2, 5 }, { 8, 4 }, { 0, -1 } };
            int count = 0;
            Console.WriteLine("Enter your values separated by space.");
            for (int a = 0; a < 5; a++)
            {
                // var values = (Console.ReadLine().Split(' '));
                for (int j = 0; j < 5; j++)
                {
                    matrix[a, j] = count++;
                }
            }
            Console.WriteLine();
            //to write 
            for (int a = 0; a < 5; a++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[a, j].ToString().Length == 2)
                        Console.Write(matrix[a, j] + " ");
                    else
                        Console.Write(matrix[a, j] + "  ");
                }
                Console.WriteLine();
            }

            List<int> result = new List<int>();
            int row = matrix.GetLength(0); 
             int column = matrix.GetLength(1);

             int i, x = 0, y = 0;
            /*  k - starting row index
                m - ending row index
                l - starting column index
                n - ending column index
                i - iterator
            */
            while (x < row && y < column)
            {
                /* Print the first row from the remaining rows */
                for (i = y; i < column; ++i)
                {
                    result.Add(matrix[x, i]);
                }
                x++;

                /* Print the last column from the remaining columns */
                for (i = x; i < row; ++i)
                {
                    result.Add(matrix[i, column - 1]);
                }
                column--;

                /* Print the last row from the remaining rows */
                if (x < row)
                {
                    for (i = column - 1; i >= y; --i)
                    {
                        result.Add(matrix[row - 1, i]);
                    }
                    row--;
                }

                /* Print the first column from the remaining columns */
                if (y < column)
                {
                    for (i = row - 1; i >= x; --i)
                    {
                        result.Add(matrix[i, y]);
                    }
                    y++;
                }
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
