using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class learningEf
    {
        static void Main()
        {
            //  GetAllEmpDetails();
            //  GetEmpDetailByID();
            //AddNewEmployee();
            // DeleteNewEmployee();
            //UpdateEmpDetails();
              EmployeeById();
            //CallStoredProcwithSQLParamater_insert();

            //Console.WriteLine("hello world");
            //Console.ReadLine();
            Console.WriteLine("hello world");

        }


        //------------------------------------------------------




        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename );
        //    }
        //}


        //private static void GetEmpDetailByID()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + "  " + emp.Sal + "  " + emp.Job);

        //}



        //--------------------------------------------------------------------

        //private static void AddNewEmployee()
        //{
        //    var ctx = new trainingTSQLContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "sheela";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new employee adda");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}






        //--------------------------------------------------------------------------------



        //private static void DeleteNewEmployee()
        //{
        //    var ctx = new trainingTSQLContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7521;

        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" employee deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}

        //--------------------------------------------------------------------------

        //private static void DeleteNewEmployee()
        //{
        //    var ctx = new trainingTSQLContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7566;


        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" employee deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //}


        //--------------------------------------------------------------------

        //public static void UpdateEmpDetails()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

        //    emp.Ename = "new";
        //    ctx.Update(emp);
        //    ctx.SaveChanges();
        //    Console.WriteLine("updated");
        //}

        //private static void GetEmployee()
        //{
        //    var ctx = new trainingTSQLContext();
        //    var Employees = ctx.Emps.FromSqlRaw($"getEmployeeDtls").ToList();

        //    foreach (var e in Employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}



        private static void EmployeeById()
        {
            var ctx = new trainingTSQLContext();
            var Employees = ctx.Emps.FromSqlRaw("EXECUTE getEmployeeDtls @p0", 7499).ToList();

            foreach (var em in Employees)
            {
                Console.WriteLine(em.Ename);
            }
        }


        //        private static void CallStoredProcwithSQLParamater_insert()
        //        {
        //            var ctx = new trainingTSQLContext();
        //            var param = new SqlParameter[] {
        //new SqlParameter() {
        //ParameterName = "@Empno",
        //SqlDbType = System.Data.SqlDbType.Int,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 6
        //},

        //new SqlParameter() {
        //ParameterName = "@Ename",
        //SqlDbType = System.Data.
        //SqlDbType.VarChar,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = "RDBMS concept"},

        //new SqlParameter() {
        //ParameterName = "@Job",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = "trainer"},

        //new SqlParameter() {
        //ParameterName = "@mgr",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 7666},

        //new SqlParameter() {
        //ParameterName = "@hiredate",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 1981-02-20},

        //new SqlParameter() {
        //ParameterName = "@sal",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 20000},

        //new SqlParameter() {
        //ParameterName = "@comm",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 300},

        //new SqlParameter() {
        //ParameterName = "@deptno",
        //SqlDbType = System.Data.
        //SqlDbType.Decimal,
        //Size = 100,
        //Direction = System.Data.
        //ParameterDirection.Input,
        //Value = 30},

        //};

        //            try
        //            {
        //                var result = ctx.Database.ExecuteSqlRaw("insertemployee @empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno");
        //                Console.WriteLine("added");
        //            }
        //            catch (Exception ex)
        //            {

        //                throw;
        //            }

        //            Console.WriteLine("update successful");




        //        }
    }
}
