using System;
using System.Xml.Schema;

namespace ExamPaper.entity
{
    public class People
    {
        public People(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public People()
        {
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            
            Console.WriteLine("Simple Properties Demo");
            return $"Person details:  Name = {Name}, Gender = {Gender}, Age = {Age} ";
        }
        
    }
}