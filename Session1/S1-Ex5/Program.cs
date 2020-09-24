using System;

namespace S1_Ex5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result1 = Calculator.Add(2, 15);
            Console.WriteLine(result1);
            int result2 = Calculator.Add(new int[4] {3, 21, 11, 5});
            Console.WriteLine(result2);
            Console.Out.WriteLine(Calculator.Maxi());
        }
    }
}