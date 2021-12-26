using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Employee_details
{
    public class SalesManager:Employee
    {
        private double comm;
        public SalesManager():base()    //base invoke base class non parametric constructor
        {
            comm = 0.0;
        }
        public SalesManager(string name,double basicsalary,double comm):base(empname,basicsalary)  //base keyword will invoke parametric constuctor
        {
            this.comm = comm;
        }

        public void CalculateSalary()
        {
            netpaid = basicsalary + comm;
        }

        public override string ToString()
        {
            return "net paid salary for sales manager is:  "+netpaid;


        }
    }
}
