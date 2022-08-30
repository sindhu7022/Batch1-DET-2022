using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };

            //lambda syntax

            Action<string, string> action1 = (string s1, string s2) =>
            {
                Console.WriteLine($"Hai {s1}, " +
                $"you said {s2}");
            };
            action.Invoke("sindhu");
            action1.Invoke("sindhu", "am in blore");

            Action<int, string, string> printEmp = (int id, string name, string email) =>
            {
                Console.WriteLine($"id ={id},name = {name}, email={email}");

            };
            printEmp(22854, "sindhu", "sindhu.c");
        }

        //Func<int, int, long> multiply = (x, y) =>
        //{
        //    return x * y;
        //};
        //long result = multiply(100, 100);

       
    }
}


