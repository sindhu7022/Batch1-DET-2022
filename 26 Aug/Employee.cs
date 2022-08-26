using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        int rollno;
        string ename;
        string eadd;
        int pincode;
        int phno;
        float GSalary;
        float pf;

        public Employee(int rollno, string ename, string eadd, int pincode, int phno)
        {
            this.rollno = rollno;
            this.ename = ename;
            this.eadd = eadd;
            this.pincode = pincode;
            this.phno = phno;
            this.pf = pf;
            this.GSalary = GSalary;
        }

        public float GetNetSalary()
        {
            return (GSalary - pf);
        }

        public string GetGrade()
        {
            float net = GetNetSalary();
            if (net > 10000)
                return "A";
            else if (net > 5000 && net < 10000)
                return "B";
            else
                return "C";
        }
    }
}
