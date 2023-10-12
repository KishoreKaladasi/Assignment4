using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Library
{
    public class Employee : Student
    {
        private int empid;

        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        private string empname;

        public string Empname
        {
            get { return empname; }
            set { empname = value; }
        }

        private double sal;
        public double Sal
        {
            get { return sal; }
            set { sal = value; }
        }

        public Employee(int empid, string studName, double sal, int studId, int age) : base(studId, studName, age)
        {
            Empid = empid;
            Empname = studName;
            Sal = sal;
        }



        public override void Calculate()
        {
            double HRA;
            double DA;
            double SA;
            if (Sal > 10000 && Sal < 20000)
            {
                HRA = Sal * 0.1;
                DA = Sal * 0.05;
                SA = Sal * 0.1;
                double totalSalary = Sal + HRA + DA + SA;
                Console.WriteLine("Total Salary: " + totalSalary);
            }
            if (Sal > 20000 && Sal < 70000)
            {
                HRA = Sal * 0.12;
                DA = Sal * 0.07;
                SA = Sal * 0.12;
                double totalSalary = Sal + HRA + DA + SA;
                Console.WriteLine("Total Salary: " + totalSalary);
            }

        }
    }
}
