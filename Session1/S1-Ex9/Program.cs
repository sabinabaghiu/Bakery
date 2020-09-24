using System;

namespace S1_Ex9
{
    class Program
    {
        public static string nTwice(string t, int n)
        {
            string result =t.Substring(0,n);
            result += t.Substring(t.Length - n);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(nTwice("Chocolate", 3));
        }
    }
}