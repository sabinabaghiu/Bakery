using System;
using System.Collections.Generic;

namespace S3_Ex2
{
    [Serializable]
    public class Person
    {
        public Person(string firstName, string lastName, int age, double height, bool isMarried, char sex, string[] hobbies)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.isMarried = isMarried;
            this.sex = sex;
            this.hobbies = hobbies;
        }
        
        public Person() {}

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public bool isMarried { get; set; }
        public char sex { get; set; }
        public string[] hobbies { get; set; }

        public override string ToString()
        {
            return firstName;
        }
    }
}