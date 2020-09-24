using System;

namespace S1_Ex11
{
    class Program
    {
        public static int CountClumps(int[] numbers)
        {
            int count = 0;
           // int ok = -1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int ok = 0;
                while (i < numbers.Length - 1 && numbers[i] == numbers[i+1])
                {
                    ok++;
                    i++;
                }

                if (ok >=1)
                {
                    count++;
                }
                // if (numbers[i] == numbers[i+1] && ok != numbers[i])
                // {
                //     ok = numbers[i];
                //     count++;
                // }
                // else if (ok == numbers[i])
                // {
                //     ok = -1;
                // }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountClumps(new int[12] {1,1,1,2,2,3,4,4,4,1,2,2}));
        }
    }
}