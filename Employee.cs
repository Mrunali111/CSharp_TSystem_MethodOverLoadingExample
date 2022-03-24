using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day2
{
        public class Employee
        {
            static int count;
            protected int empID;
            protected string empName;
            protected double empSalary, hra, da, pf, grosssalary;


            public Employee()
            {
                count++;
                empID = count;
                empName = "";
                empSalary = 0.00;
            }

            public Employee(string empName, double empSalary)
            {
                count++;
                empID = count;
                this.empName = empName;
                this.empSalary = empSalary;
            }

            public override string ToString()
            {
                return "Employee ID : " +empID+ "\nEmployee Name : " + empName + "\nEmployee Salary : " + grosssalary;
            }

            public static int  GetCount()
            {
            return count;

            }

            public virtual void CalculateSalary()
            {
                hra = empSalary * 0.40;
                da = empSalary * 0.20;
                pf = empSalary * 0.10;
                grosssalary = (hra + da + empSalary) - pf;
            }

        }
}
