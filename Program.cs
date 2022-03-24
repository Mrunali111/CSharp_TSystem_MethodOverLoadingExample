using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Employee emp = new Employee("Mrunali", 35000);
            emp.CalculateSalary();
            Console.WriteLine(emp);
            Console.WriteLine("======================================");

            Employee emp2 = new Employee("Taksh", 35000);
            emp2.CalculateSalary();
            Console.WriteLine(emp2);
            Console.WriteLine("======================================");

            Employee emp3 = new Employee("Atul", 35000);
            emp3.CalculateSalary();
            Console.WriteLine(emp3);
            Console.WriteLine("======================================");

            Console.WriteLine("Total Number of Employees are : "+ Employee.GetCount());

            //Manager man1= new Manager();
            //man1.CalculateSalary();
            //Console.WriteLine(man1);
            //Console.WriteLine("======================================");

            //Manager man2 = new Manager(2,"Shruti",34000,5000,2000);
            //man2.CalculateSalary();
            //Console.WriteLine(man2);
            //Console.WriteLine("======================================");

            //SalesManager sman = new SalesManager(3, "Atul", 30000, 5000, 6000, 2000);
            //sman.CalculateSalary();
            //Console.WriteLine(sman);
            //Console.WriteLine("======================================");

            //MethodOverloading mo = new MethodOverloading();
            //mo.Addition(22, 6);
            //Console.WriteLine(mo);






            Console.ReadLine();

        }
    }
}
