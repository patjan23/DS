using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenOfLastowrd
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "        ";
            int x =   LengthOfLastWord(k);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        private static int LengthOfLastWord(string k)
        {
            if (k == string.Empty)
                return 0;

            if (k[k.Length-1] == ' ')
                return 0;

            Stack<int> st = new Stack<int>();        

            foreach (var item in k.Split(' '))
            {
                st.Push(item.Length);
            }

            return st.Pop();
        }
    }
}
