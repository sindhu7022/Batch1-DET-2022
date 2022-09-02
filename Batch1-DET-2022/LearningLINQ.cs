using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearningLINQ
    { 
        public static void Main()
    {
        SampleIntList();
    }
    
        private static void SampleIntList()
        {
            //the three parts of a LINQ Query:deffered execution
            // 1. Data Source

            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            // 2. Query Creation .sql type

            // var numQuery = from num in numbers // select num from  numbers
            //              select num;
            // numbers.Add(200);

            //early execution
            //var numQuery = (from num in numbers //select num from numbers
            //                select num).ToList();
            //numbers.Add(200);

            //var numQuery = from num in numbers
            //               where num>102// select num from  numbers
            //           select num;

            //LAMBDA EXP
            //var numQuery = numbers.Select(x => x);

            //LAMBDA EXP
            var numQuery = numbers.Where(x => x>102);






            // 3. Query Execution

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0}", num);
                //num.Dump(); //this is for LINQPad not for VS
            }
            Console.ReadLine();
        }
        
    }
}
    
