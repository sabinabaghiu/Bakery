using System;

namespace S1_Ex7
{
    class Program
    {
        public static string MakeAbba(string t1, string t2)
        {
            return $"{t1}{t2}{t2}{t1}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MakeAbba("Hi", "Bro"));
            Console.WriteLine((MakeAbba("oh", "wow")));
        }
    }
}