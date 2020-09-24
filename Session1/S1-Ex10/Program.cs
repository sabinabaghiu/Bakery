using System;

namespace S1_Ex10
{
    class Program
    {
        public static int bigDiff(int[] numbers)
        {
            int maxi = numbers[0];
            int mini = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxi < numbers[i])
                {
                    maxi = numbers[i];
                }

                if (mini > numbers[i])
                {
                    mini = numbers[i];
                }
            }
            int dif = maxi - mini;
            return dif;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(bigDiff(new int[4] {7, 2, 10, 9}));
        }
    }
}