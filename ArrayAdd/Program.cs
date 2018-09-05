using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAdd
{
    class Program
    {
        static void Main(string[] args)
        {

            

                List<int> lst = new List<int>();
                lst.Add(1);
                lst.Add(2);
                lst.Add(3);

            int sum = 0;

                while (lst.Count != 1)
                {
                     sum = lst[0] + lst[1];
                    lst.RemoveAt(0);
                  lst.RemoveAt(0);
                lst.Add(sum);
                }

            Console.WriteLine(sum);
            Console.ReadKey();
               

            

        }
    }
}
