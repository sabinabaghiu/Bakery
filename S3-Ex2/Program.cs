using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace S3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person p1 = new Person("Bob", "Smith", 25, 1.80, false, 'm', new string[2] {"walking", "painting"});
            Person p2 = new Person("Anne", "Cutberth", 30, 1.72, true, 'f', new string[1] {"reading"});
            Person p3 = new Person("Alex", "Dumphy", 21, 1.67, false, 'f', new string[3] {"sience", "reading", "traveling"});
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            
            storeObjects(persons);

            foreach (Person person in readFromFile())
            {
                Console.WriteLine(person);
            }
        }
        
        private static void storeObjects(List<Person> persons)
        {
            using (StreamWriter file = new StreamWriter("MyLines.txt"))
            {
                string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {    WriteIndented = true});
                    file.WriteLine(jsonFormatted);
            }
        }

        private static List<Person> readFromFile()
        {
            var result = new List<Person>();
            using (StreamReader sr = new StreamReader("MyLines.txt"))
            {
                var json = sr.ReadToEnd();
                result = JsonSerializer.Deserialize<List<Person>>(json);
            }

            return result;
        }
    }
}