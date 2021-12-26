using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Employee_details
{
    public class ProductManager:Employee
    {
        private double foodall,medicalall;
        public ProductManager():base()
        {
            foodall = 200;
            medicalall = 300;
        }

        /*
        public ProductManager(string empname,double basicsalary,double foodall,double medicalall):base(empname,basicsalary)
        {
            this.foodall = foodall;
            this.medicalall = medicalall;
        }*/
        
        /*
        public override void calculate()
        {
            hra = 0.2f * basicsalary;
            da = 0.2f * basicsalary;
            ta = 0.25f* basicsalary;
            pf = 0.12f * basicsalary;
            netpaid = hra + da + ta + pf + basicsalary + foodall + medicalall;
        }*/

      
        public override string ToString()
        {

            return "product manager: \nID" +empid+"\nname: "+empname+"\nsalary: "+ basicsalaryta = 0.25f * basicsalary; ;
        }
    }
}
