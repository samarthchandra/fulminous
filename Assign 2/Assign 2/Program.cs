using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 55, 26, 32, 9, 6, 31, 19, 82, 60, 47 };

        numbers.Sort();
        Console.WriteLine("List arrange in ascending order:");
        PrintList(numbers);

        numbers.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("\nList arrange in descending order:");
        PrintList(numbers);


        int searchNumber = 47;
        bool found = numbers.Contains(searchNumber);
        Console.WriteLine($"\nIs the number {searchNumber} in the list? {found}");
    }

    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}