using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
namespace Batch1_DET_2022
{
    internal class EFCoreLearning
    {
        static void Main(string[] args)
        {
            //GetAllEmpDetails();
            //GetAllEmpDetailsByID();
            // AddNewEmployee();
            //UpdateEmpDetails();
            //DeleteNewEmployee();
            //WithoutParams();
            CallStoredProcwithSQLParamater_insert();
         //   WithParams();
            Console.ReadLine();
        }
        //private static void AddNewEmployee()
        //{
        //    var ctx = new sindhu_22854Context();

        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp employee = new Models.Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "sindhu";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new employee added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void DeleteNewEmployee()
        //{
        //    var ctx = new sindhu_22854Context();

        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp employee = new Models.Emp();
        //        employee.Empno = 7934;


        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" employee deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void UpdateEmpDetails()
        //{
        //    var ctx = new sindhu_22854Context();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

        //    emp.Ename = "shilpa";
        //    ctx.Update(emp);
        //    ctx.SaveChanges();
        //    Console.WriteLine("updated");
        //}


        //private static void GetAllEmpDetailsByID()
        //{
        //    var ctx = new sindhu_22854Context();
        //    var Emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(Emp.Ename + " " + Emp.Sal + " " + Emp.Job);
        //}

        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new sindhu_22854Context();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + " " + emp.Sal);
        //    }
        //}

        private static void WithoutParams()

        {

            var ctx = new sindhu_22854Context();
            var Emp = ctx.Emps.FromSqlRaw("GetEmpDetailss").ToList();
            foreach (var e in Emp)
            {
                Console.WriteLine(e.Ename);

            }

        }

        private static void WithParams()

        {

            var ctx = new sindhu_22854Context();
            var Emp = ctx.Emps.FromSqlRaw($"getallempdetails_byempno  @p0", 7844).ToList();
            foreach (var e in Emp)
            {
                Console.WriteLine(e.Ename);

            }

        }

        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new sindhu_22854Context();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@EMPNO",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 6
                        },

                         new SqlParameter() {
                            ParameterName = "@ENAME",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "RDBMS concept"},

                          new SqlParameter() {
                            ParameterName = "@JOB",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 100}

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);
                
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }
    }
}
