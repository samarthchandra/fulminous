using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Lichi",
            "KIWI",
            "Dragon Fruit"
        };


        Console.WriteLine(" List of fruits:");
        PrintList(fruits);


        fruits.Add("Strawberry");
        Console.WriteLine("\n Adding a new fruit:");
        PrintList(fruits);


        fruits.RemoveAt(2);
        Console.WriteLine("\n Removing the third fruit:");
        PrintList(fruits);


        Console.WriteLine($"\nThe third fruit in the list is: {fruits[2]}");


        string fruitToCheck = "Apple";
        bool containsFruit = fruits.Contains(fruitToCheck);
        Console.WriteLine($"\nDoes the list contain '{fruitToCheck}'? {containsFruit}");
    }

    static void PrintList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}