using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Date   //default access specifier is pivate
    {
        private int day, year;
        private string month;
        
        public void SetData()  //method to init values to the member
        {
            day = 10;
            month = "may";
            year = 2020;

        }

        public string GetData()  //get method for date class which gets value
        {
            return "date is: " + day + "/" + month + "/" + year;
        }
    }
}
