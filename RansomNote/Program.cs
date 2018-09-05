using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] tokens_m = Console.ReadLine().Split(' ');
            //int m = Convert.ToInt32(tokens_m[0]);
            //int n = Convert.ToInt32(tokens_m[1]);
            
            string[] magazine = ("give me one grand today night").Split(' ');
            string[] ransom = ("give one grands today").Split(' ');

            Dictionary<string, int> mag =
              new Dictionary<string, int>();
            Dictionary<string, int> ran =
               new Dictionary<string, int>();

            AddContent(mag, magazine);
            AddContent(ran, ransom);

            bool result = true;
            foreach (KeyValuePair<string, int> item in ran)
            {
                if (!mag.Contains(item))
                {
                    if (mag.ContainsKey(item.Key) && mag[item.Key] < item.Value)
                        result = false;
                }

            }

            if (result == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static void AddContent(Dictionary<string, int> dic, string[] str)
        {

            foreach (var k in str)
            {
                if (dic.ContainsKey(k))
                {
                    dic[k]++;
                }
                else
                {
                    dic.Add(k, 1);
                }
            }

        }
    }
}
