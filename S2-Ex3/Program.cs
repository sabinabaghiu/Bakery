using System;

namespace S2_Ex3
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

            public int Hour => (minutes / 60) % 24;

            public int Minute => minutes % 60;

            public int AddMinutes(int minutes)
            {
                this.minutes += minutes;
                if (this.minutes > 59)
                {
                    minutes -= 60;
                }

                return minutes;
            }

            public int SubtractMinutes(int minutes)
            {
                this.minutes -= minutes;
                if (this.minutes < 0)
                {
                    minutes += 60;
                }

                return minutes;
            }

            public override string ToString()
            {
                return $@"{Hour.ToString("D2")}:{Minute.ToString("D2")}";
            }
        }
        
        static void Main(string[] args)
        {
            Time t1 = new Time(45, 23);
            t1.SubtractMinutes(50);
            Console.Out.WriteLine(t1.ToString());
           
        }
    }
}