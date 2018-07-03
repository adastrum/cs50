using System;
using System.Collections.Generic;

namespace cs50
{
    internal class Program
    {
        private static void Main()
        {
            var sorter = new Sorter();
            var numbers = new[] { 1, 3, 5, 6, 4, 2, 9, 8, 7, 0, 0, 0 };
            var sorted = sorter.MergeSort(numbers);
            PrintNumbers(numbers);
            PrintNumbers(sorted);
            Console.ReadLine();
        }

        private static void PrintNumbers(IEnumerable<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
