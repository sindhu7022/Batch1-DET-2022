using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Partitioning
    {


        #region "partitioning"
        //SKIP


        //public static void Main()
        //{
        //    Sample_Skip_Lambda();
        //}
        //static void Sample_Skip_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.Skip(2);

        //    Console.WriteLine("Skips the first 2 words:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}

        // SKIP WHILE

        //public static void Main()
        //{
        //    Sample_SkipWhile_Lambda();
        //}
        //static void Sample_SkipWhile_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.SkipWhile(w => w.Length == 5);

        //    Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}


        // TAKE


        //public static void Main()
        //{
        //    Sample_Take_Lambda();
        //}
        //static void Sample_Take_Lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.Take(3);

        //    Console.WriteLine("Takes the first 3 numbers only:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}


        // TAKE WHILE

        //public static void Main()
        //{
        //    Sample_TakeWhile_Lambda();
        //}
        //static void Sample_TakeWhile_Lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.TakeWhile(n => n < 3);

        //    Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}
        #endregion

        #region "aggregation"
        //AGGREGATION

        //public static void Main()
        //{
        //    Sample_Sum_Lambda();
        //}
        ////simple

        //static void Sample_Aggregate_Lambda_Simple()
        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}

        ////average
        //static void Sample_Average_Lambda()
        //{
        //    int[] numbers = { 10, 10, 11, 11 };

        //    var result = numbers.Average();

        //    Console.WriteLine("Average is:");
        //    Console.WriteLine(result);
        //}

        //// count

        //static void Sample_Count_Lambda()
        //{
        //    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

        //    var result = names.Count();

        //    Console.WriteLine("Counting names gives:");
        //    Console.WriteLine(result);
        //}

        ////min

        //static void Sample_Min_Lambda()
        //{
        //    int[] numbers = { 6, 0, 3, 7, 5 };

        //    var result = numbers.Min();

        //    Console.WriteLine("Lowest number is:");
        //    Console.WriteLine(result);
        //}

        ////max

        //static void Sample_Max_Lambda()
        //{
        //    int[] numbers = { 20,2, 8, 5, 6, 1 };

        //    var result = numbers.Max();

        //   Console.WriteLine("Highest number is:");
        //    Console.WriteLine(result);
        //}

        ////sum

        //static void Sample_Sum_Lambda()
        //{
        //    int[] numbers = { 2, 5, 10 };

        //    var result = numbers.Sum();

        //    Console.WriteLine("Summing the numbers yields:");
        //    Console.WriteLine(result);
        //}
        #endregion

        #region "set"
        public static void Main()
        {
            Sample_Intersect_Lambda();
        }

        ////distinct
        //    static void Sample_Distinct_Lambda()
        //{
        //    int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

        //    var result = numbers.Distinct();

        //    Console.WriteLine("Distinct removes duplicate elements:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        //intersect
        static void Sample_Intersect_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        ////union

        static void Sample_Union_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }


        #endregion

        #region "Quantifiers"

        //public static void Main()
        //{
        //    Sample_Contains_Lambda();
        //}

        ////ALL

        //static void Sample_All_Lambda()
        //{
        //    string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //    var result = names.All(n => n.StartsWith("B"));

        //    Console.WriteLine("Does all of the names start with the letter 'B':");
        //    Console.WriteLine(result);
        //}
        ////any

        //static void Sample_Any_Lambda()
        //{
        //    string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //    var result = names.Any(n => n.StartsWith("B"));

        //    Console.WriteLine("Does any of the names start with the letter 'B':");
        //    Console.WriteLine(result);
        //}

        ////contains

        //static void Sample_Contains_Lambda()
        //{
        //    int[] numbers = { 1, 3, 5, 7, 9 };

        //    var result = numbers.Contains(5);

        //    Console.WriteLine("sequence contains the value 5:");
        //    Console.WriteLine(result);
        //}
        #endregion

        #region "elements"

        //public static void Main()
        //{
        //    Sample_Single_Lambda();
        //}

        ////element_at
        //static void Sample_ElementAt_Lambda()
        //{
        //    string[] words = { "One", "Two", "Three" };

        //    var result = words.ElementAt(1);

        //    Console.WriteLine("Element at index 1 in the array is:");
        //    Console.WriteLine(result);
        //}

        ////element_at_or_default

        //static void Sample_ElementAtOrDefault_Lambda()
        //{
        //    string[] colors = { "Red", "Green", "Blue" };

        //    var resultIndex1 = colors.ElementAtOrDefault(1);

        //    var resultIndex10 = colors.ElementAtOrDefault(10);

        //    Console.WriteLine("Element at index 1 in the array contains:");
        //    Console.WriteLine(resultIndex1);

        //    Console.WriteLine("Element at index 10 in the array does not exist:");
        //    Console.WriteLine(resultIndex10 == null);
        //}

        ////first_simple
        //// Note: Operator First will throw an exception, if there is not at least one element in the sequence.
        //static void Sample_First_Lambda_Simple()
        //{
        //    string[] fruits = { "Banana", "Apple", "Orange" };

        //    var result = fruits.First();

        //    Console.WriteLine("First element in the array is:");
        //    Console.WriteLine(result);
        //}

        ////first_conditional
        //static void Sample_First_Lambda_Conditional()
        //{
        //    string[] countries = { "Denmark", "Sweden", "Norway" };

        //    var result = countries.First(c => c.Length == 6);

        //    Console.WriteLine("First element with a length of 6 characters:");
        //    Console.WriteLine(result);
        //}

        ////FirstOrDefault

        //// Note: While First() will throw an exception if array...
        ////       ...is empty, FirstOrDefault gracefully returns null.
        //static void Sample_FirstOrDefault_Lambda()
        //{
        //    string[] countries = { "Denmark", "Sweden", "Norway" };
        //    string[] empty = { };

        //    var result = countries.FirstOrDefault();

        //    var resultEmpty = empty.FirstOrDefault();

        //    Console.WriteLine("First element in the countries array contains:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("First element in the empty array does not exist:");
        //    Console.WriteLine(resultEmpty == null);
        //}

        ////last
        //static void Sample_Last_Lambda()
        //{
        //    int[] numbers = { 7, 3, 5 };

        //    var result = numbers.Last();

        //    Console.WriteLine("Last number in array is:");
        //    Console.WriteLine(result);
        //}

        ////LastOrDefault_Simple
        //// Note: While Last will throw an exception if array...
        ////       ...is empty, LastOrDefault gracefully returns null.
        //static void Sample_LastOrDefault_Simple()
        //{
        //    string[] words = { "one", "two", "three" };
        //    string[] empty = { };

        //    var result = words.LastOrDefault();

        //    var resultEmpty = empty.LastOrDefault();
        //    Console.WriteLine("Last element in the words array contains:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array does not exist:");
        //    Console.WriteLine(resultEmpty == null);
        //}

        //// LastOrDefault_Conditional
        //// Note: While Last will throw an exception if array...
        ////       ...is empty, LastOrDefault gracefully returns null.
        //static void Sample_LastOrDefault_Conditional()
        //{
        //    string[] words = { "one", "two", "three" };

        //    var result = words.LastOrDefault(w => w.Length == 3);

        //    var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

        //    Console.WriteLine("Last element in the words array having a length of 3:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
        //    Console.WriteLine(resultNoMatch == null);
        //}

        ////single

        //// Note: Single will throw an Exception, if there is not exactly one element in the array.
        //static void Sample_Single_Lambda()
        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.Single();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    try
        //    {
        //        // This will throw an exception because array contains no elements
        //        var resultEmpty = empty.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        ////SingleOrDefault
        //// Note: SingleOrDefault retrieves null value if array is empty, and...
        ////       ...throws an exception if array contains more than one element.
        //static void Sample_SingleOrDefault_Lambda()
        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.SingleOrDefault();

        //    var resultEmpty = empty.SingleOrDefault();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
        //    Console.WriteLine(resultEmpty == null);

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.SingleOrDefault();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        #endregion
    }
}
