using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Ordering_LINQ

    {

        // ORDERING SIMPLE NUMBERS USING LAMBDA

        //public static void Main()
        //{
        //    Sample_OrderBy_Lambda_Numbers();
        //}

        //static void Sample_OrderBy_Lambda_Numbers()
        //{
        //    int[] numbers = { 7, 9, 5 };

        //    var result = numbers.OrderBy(n => n);

        //    Console.WriteLine("Ordered list of numbers:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        // ORDERING NAMES IN DESCENDING ORDER USING LAMBDA

        //public static void Main()
        //{
        //    Sample_OrderByDescending_Lambda();
        //}

        //static void Sample_OrderByDescending_Lambda()
        //{
        //    string[] names = { "sindhu", "nidhi", "xoxo" ,"xoxi"};

        //    var result = names.OrderByDescending(n => n);

        //    Console.WriteLine("Descending ordered list of names:");
        //    foreach (string name in result)
        //        Console.WriteLine(name);
        //}

        //REVERSING CHARACTERS


        //public static void Main()
        //{
        //    Sample_Reverse_Lambda();
        //}

        //static void Sample_Reverse_Lambda()
        //{
        //    char[] characters = { 'z', 'y', 'm', 'a', 'l', 'v' };

        //    var result = characters.Reverse();

        //    Console.WriteLine("Characters in reverse order:");
        //    foreach (char character in result)
        //        Console.WriteLine(character);
        //}

        //THEN BY
        //public static void Main()
        //{
        //    Sample_ThenBy_Lambda();
        //}
        //static void Sample_ThenBy_Lambda()
        //{
        //    string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
        //                  "Athens", "Beijing", "Seoul" };

        //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console.WriteLine(capital);
        //}

        // THEN  BY DESCENDING
        public static void Main()
        {
            Sample_ThenByDescending_Lambda();
        }

        static void Sample_ThenByDescending_Lambda()
        {
            var dates = new DateTime[] {
        new DateTime(2022, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2021, 1, 1),
        new DateTime(2015, 7, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }


    }
    }
