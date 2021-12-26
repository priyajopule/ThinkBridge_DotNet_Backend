using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3_properties
{
    public class Student
    {  /*
        private int rollno;

        public int RollNo       //property
        {
            set { rollno = value; }  //build in
            get { return rollno; }
        }

        private string name;

        public string Name      //property
        { 
            set { name = value; }
            get { return name; }
        }*/


        


     
        public int RollNo { get ; set; }     //auto implemented property
        public string Name { get; set; }

        public double percentage { get; set; }
        public override string ToString()
        {
            return "Details---> \n rollno: "+RollNo+"\n name: "+Name+ "\n percentage: " +percentage;
        }

    }
}
