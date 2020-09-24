using System;

namespace S1_Ex8
{
    class Program
    {
        public static string makeOutWord(string t1, string t2)
        {
           return t1.Insert(2, t2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(makeOutWord("<<>>", "yay"));
            Console.WriteLine(makeOutWord("[[]]", "words"));
        }
    }
}