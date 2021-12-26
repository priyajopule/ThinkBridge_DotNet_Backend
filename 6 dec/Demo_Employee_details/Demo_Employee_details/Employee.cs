using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_Employee_details
{
   
    public enum Department
    {
        HR=1,development,testing,sales
    }

    [Project(Version="1.0.0.0.",Name ="hotel management system")]
    
    
    public class Employee                   //base class
    {

        private static int count;           // intial value is 0
        private int empid;
        protected double basicsalary,netpaid;
        private string empname;
        private double hra, da, ta, pf;
        private Department department;

        
        public Employee()
        {
            empid = ++count;
           //empid = 1;
            basicsalary = 25000;
            empname = "priya";

           
        }

        public Employee(double salary, string ename)
        {
            empid = ++count;                 
            //empid = id;
            //this.basicsalary = basicsalary;   // this keyword refers to the data member
            //this.empname = empname;
            basicsalary = salary;
            empname = ename;
        }

        public virtual void calculate()
        {
            hra = 0.2f * basicsalary;
            da = 0.2f * basicsalary;
            ta = 0.25f * basicsalary;
            pf = 0.12f * basicsalary;
            netpaid = hra + da + ta + pf + basicsalary;
        }

        /*
        public override string ToString()
        {
            return "id: "+empid+ "\nbasicsalary : "+basicsalary+ "\nname :"+empname;

        }*/

    }

    }
