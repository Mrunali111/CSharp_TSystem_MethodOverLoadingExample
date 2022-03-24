//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TSystem_Day2
//{
//    public class Manager : Employee
//    {
//        private double foodallow, travelallow;

//        public Manager() : base()
//        {
//            foodallow = 0.0;
//            travelallow = 0.0;
//        }

//        public Manager(int ID, string Name, double Salary,double foodallow, double travelallow) : base(ID,Name,Salary)
//        {
//            this.foodallow= foodallow;
//            this.travelallow= travelallow;
//        }

//        public override void CalculateSalary()
//        {
//            hra = empSalary * 0.40;
//            da = empSalary * 0.20;
//            pf = empSalary * 0.10;
//            grosssalary = (hra + da + empSalary + foodallow + travelallow) - pf;
//        }

//        public override string ToString()
//        {
//            return "Employee ID : " + empID + "\nEmployee Name : " + empName + "\nEmployee Salary : " + grosssalary;
//        }
//    }
//}
