using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqAssignments
    {
        public static void Main()
        {
            contains_o();
        }
        static void contains_o()
        {
            string[] names = { "john", "peter", "jacob", "harry", "jackson" };

            var result = from name in names
                         where name.Contains("o")
                         select name;
            foreach (var name in result)
            Console.WriteLine(name);
        }

        



    }
}