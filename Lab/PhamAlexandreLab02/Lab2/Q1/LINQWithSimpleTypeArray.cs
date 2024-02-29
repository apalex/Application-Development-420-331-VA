using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class LINQWithSimpleTypeArray
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            Console.Write("Original array:");
            foreach (var value in values)
            {
                Console.Write($" {value}");
            }

            // LINQ Query
            var filtered =
                from value in values
                where value > 4
                select value;

            Console.Write("\nArray values greater than 4:");
            foreach (var value in filtered)
            {
                Console.Write($" {value}");
            }

            var sorted =
                from value in values
                orderby value
                select value;

            Console.Write("\nOriginal array, sorted:");
            foreach (var value in sorted)
            {
                Console.Write($" {value}");
            }

            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (two queries):");
            foreach (var value in sortFilteredResults)
            {
                Console.Write($" {value}");
            }

            var sortAndFilter =
                from value in values
                where value > 4
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (one query):");
            foreach (var value in sortAndFilter)
            {
                Console.Write($" {value}");
            }
            Console.WriteLine();
        }
    }
}
