using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndLinq.StringProcessing
{
    public class StringSorter
    {
        public static void Run()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Kiwi", "Strawberry", "Mango", "Pear" };

            // Sort strings based on their length in ascending order using lambda expression
            var sortedFruits = fruits.OrderBy(s => s.Length).ToList();

            Console.WriteLine(" Fruits sorted by length (Ascending) ");
            foreach (var fruit in sortedFruits)
            {
                Console.WriteLine($"{fruit} (Length: {fruit.Length})");
            }
        }
    }
}
