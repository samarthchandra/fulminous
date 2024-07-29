using System;
using System.Collections.Generic;

namespace Assign_3
{
 class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> StudentScores = new Dictionary<string, int>();

            StudentScores.Add("Chandragupt",90);
            StudentScores.Add("Divyansh", 92);
            StudentScores.Add("Uday", 96);
            StudentScores.Add("Vanshika", 91);
            StudentScores.Add("Shailja", 96);

            Console.WriteLine("Student Scores:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            StudentScores["Shailja"] = 91;
            Console.WriteLine("\n Update Scores:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            StudentScores.Remove("Shailja");
            Console.WriteLine("\nAfter Removing Shailja:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine($"\n Score of Chandragupt: {StudentScores["Chandragupt"]}");
        }
    }
}