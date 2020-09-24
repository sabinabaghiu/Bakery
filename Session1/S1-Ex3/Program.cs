using System;

namespace S1_Ex1
{
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            System.Console.WriteLine("Hi, I am " + Name);
        }
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Sabina";
            p.Introduce();
        }
    }
}