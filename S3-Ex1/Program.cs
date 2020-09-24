using System;
using System.Collections.Generic;
using System.Text.Json;

namespace S3_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Person p1 = new Person("Bob", "Smith", 25, 1.80, false, 'm', new string[2] {"walking", "painting"});
            Person p2 = new Person("Anne", "Cutberth", 30, 1.72, true, 'f', new string[1] {"reading"});
            Person p3 = new Person("Alex", "Dumphy", 21, 1.67, false, 'f', new string[3] {"sience", "reading", "traveling"});
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            for (int i = 0; i < 3; i++)
            {
                Console.Out.WriteLine(list[i]);
                Console.Out.WriteLine("");
            }
            // string jsonFormatted = JsonSerializer.Serialize(list);
            // Console.Out.WriteLine(jsonFormatted);
        }
    }
}