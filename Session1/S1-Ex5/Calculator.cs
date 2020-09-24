using System;

namespace S1_Ex5
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static int Maxi()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            return Math.Max(x, y);
        }
    }
}