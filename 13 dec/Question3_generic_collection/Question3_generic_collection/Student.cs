using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3_generic_collection
{
    public class Student
    {
        public int Rollno { get; set; }

        public string Name { get; set; }

        public char Grade { get; set; }

        public override string ToString()
        {
            return "RollNo: "+Rollno+ " Name: "+Name+ " Grade: "+Grade;
        }

    }
}
