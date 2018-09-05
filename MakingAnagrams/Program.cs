using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "cde";// Console.ReadLine();
            string b = "abc";// Console.ReadLine();
            int k = remAnagram(a, b);
        }


        static int remAnagram(String str1, String str2)
        {
            // make hash array for both string 
            // and calculate frequency of each
            // character
            int[] count1 = new int[26];
            int[] count2 = new int[26];

            // count frequency of each charcter 
            // in first string
            for (int i = 0; i < str1.Length; i++)
                count1[str1[i] - 'a']++;

            // count frequency of each charcter 
            // in second string
            for (int i = 0; i < str2.Length; i++)
                count2[str2[i] - 'a']++;

            // traverse count arrays to find 
            // number of charcters to be removed
            int result = 0;
            for (int i = 0; i < 26; i++)
                result += Math.Abs(count1[i] -
                                   count2[i]);
            return result;
        }
    }
}
