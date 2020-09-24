using System;

namespace S2_Ex2
{
    class Program
    {
        public struct Time
        {
            private int minutes;

            public Time(int minutes, int hours)
            {
                this.minutes = minutes + 60 * hours;
            }

            public int Hour => minutes / 60;

            public int Minute => minutes % 60;

            public override string ToString()
            {
                return $@"{Hour.ToString("D2")}:{Minute.ToString("D2")}";
            }
        }
        
        static void Main(string[] args)
        {
            Time t1 = new Time(45, 23);
            Console.Out.WriteLine(t1.ToString());
           
        }
    }
}