using System;

namespace S1_Ex4
{
    class Program
    {
        public void Even(int x)
        {
            for (int i = 0; i <=x ; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        
        public void Uneven(int x)
        {
            for (int i = 0; i <=x ; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        
        public void Divisible(int x, int y)
        {
            for (int i = 0; i <=x ; i++)
            {
                if (i % y == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        
        static void Main(string[] args)
        {
            var p = new Program();
            p.Even(20);
            p.Uneven(32);
            p.Divisible(50,6);
        }
    }
}