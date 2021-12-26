using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentDetails
    {
        private int roll_no;
        private string name;
        private string stu_class;

        public void SetData()
        {
            roll_no = 1;
            name = "priya";
            stu_class = "BE";
        }

        public string GetData()
        {
            return "roll_no: " +roll_no+ "\nname: " +name+ "\nclass: " +stu_class;
        }
    }
}
