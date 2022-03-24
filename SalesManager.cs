//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TSystem_Day2
//{
//    public class SalesManager : Employee
//    {
//        private double FoodAllow, TravelAllow, Commision;

//        public SalesManager() : base()
//        {
//            FoodAllow = 0.0;
//            TravelAllow = 0.0;
//            Commision = 0.0;
//        }

//        public SalesManager(int ID, string Name, double Salary, double FoodAllow, double TravelAllow, double Commission) : base(ID, Name, Salary)
//        {
//            this.FoodAllow = FoodAllow;
//            this.TravelAllow = TravelAllow;
//            this.Commision = Commission;

//        }

//        public override void CalculateSalary()
//        {
//            hra = empSalary * 0.40;
//            da = empSalary * 0.20;
//            pf = empSalary * 0.10;
//            grosssalary = (hra + da + empSalary + FoodAllow + TravelAllow+ Commision) - pf;
//        }

//        public override string ToString()
//        {
//            return "Employee ID : " + empID + "\nEmployee Name : " + empName + "\nEmployee Salary : " + grosssalary;
//        }
//    }


//}
