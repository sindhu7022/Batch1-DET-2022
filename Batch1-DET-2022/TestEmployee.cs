using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmployee
    {
    
        public static void Main()
        {
            Employee ceo = new Employee(22854, "sindhu", "RCR", 741852963, 50252);
            float NET = ceo.GetNetSalary();
            string GRADE = ceo.GetGrade();
            Console.WriteLine($"Net Salary = {NET}, Grade = {GRADE}");
        }
    }
}
