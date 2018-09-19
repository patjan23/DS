using System;

namespace ShuffleCard
{
    class Program
    {

        public static void Shuffle(int[] card,
                              int n)
        {

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {

                // Random for remaining positions.
                int r = i + rand.Next(52 - i);

                //swapping the elements
                int temp = card[r];
                card[r] = card[i];
                card[i] = temp;

            }
        }
        static void Main(string[] args)
        {
            int[] a = {0, 1, 2, 3, 4, 5, 6, 7, 8,
                   9, 10, 11, 12, 13, 14, 15,
                   16, 17, 18, 19, 20, 21, 22,
                   23, 24, 25, 26, 27, 28, 29,
                   30, 31, 32, 33, 34, 35, 36,
                   37, 38, 39, 40, 41, 42, 43,
                   44, 45, 46, 47, 48, 49, 50,
                   51};

            Shuffle(a, 52);

            // Printing all shuffled elements of cards
            for (int i = 0; i < 52; i++)
                Console.Write(a[i] + " ");

            Console.ReadKey();
        }
    }
}
