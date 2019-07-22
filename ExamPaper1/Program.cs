using System;
using ExamPaper.entity;

namespace ExamPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new People
            {
                Name = "Marry",
                Gender = "Male",
                Age = 25
            };
            Console.WriteLine(people.ToString());
            people.Age = 35;
            Console.WriteLine("Person details (apter incrementing age): Name = " + people.Name + ", Gender ="
                              + people.Gender + ", Age =" + people.Age);
        }
    }
}