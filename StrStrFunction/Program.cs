using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrStrFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string needle = "bba";
            //string hay = "aabbbabbabbbaaba";

            //string needle = "bba";
            //string hay = "aabaaaababaabbbabbabbbaabababaaaaaababaaabbabbabbabbaaaabbbbbbaabbabbbbbabababbaaabbaabbbababbb";


            string needle = "ll";
            string haystack = "hello";
            int position = 0;

            position = StrStr(needle, haystack);

            Console.WriteLine(position);
            Console.ReadKey();
            

        }

        public static int StrStr(string haystack, string needle)
        {

            int position = -1;

            if (haystack.Equals(string.Empty) && needle.Equals(string.Empty))
                return 0;

            if (needle.Equals(string.Empty))
                return 0;

            if (haystack.Equals(string.Empty))
                return -1;

            if (needle.Equals(string.Empty))
                return 0;

            if (needle.Length > haystack.Length)
                return -1;

            if ((needle.Length == haystack.Length) && (haystack.Contains(needle)))
                return 0;

            if (haystack.Contains(needle))
            {
                for (int i = 0; i < (haystack.Length - needle.Length) + 1; i++)
                {
                    bool[] targetbool = new bool[needle.Length];
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i + j] == needle[j])
                            targetbool[j] = true;
                    }
                    if (!targetbool.Contains(false))
                    {
                        position = i;
                        return position;
                    }
                }
            }
            return position;

        }

        private static int StrStr1(string needle, string haystack)
        {
            int position = -1;
            if (needle.Equals(string.Empty) || haystack.Equals(string.Empty))
                position = -1;

            if (needle.Length > haystack.Length)
                position = -1;

            if (haystack.Contains(needle) )
            {
                for (int i = 0; i < (haystack.Length - needle.Length) + 1; i++)
                {
                    bool[] targetbool = new bool[needle.Length];
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i + j] == needle[j])
                            targetbool[j] = true;
                    }
                    if (!targetbool.Contains(false))
                    {
                        position = i;
                        break;
                    }
                }
            }

            return position;
        }
    }
}
