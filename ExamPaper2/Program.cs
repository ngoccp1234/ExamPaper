using System;
using System.Text.RegularExpressions;

namespace ExamPaper2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Enter a String Aptech Computer Center";
            Console.WriteLine(str);
            Console.WriteLine("Enter a word to search: ");
            string st = Console.ReadLine();
            var count = Regex.Matches(str, st).Count;
            Console.WriteLine("Word found " + count + " times in the string.");
        }
        }
    }
