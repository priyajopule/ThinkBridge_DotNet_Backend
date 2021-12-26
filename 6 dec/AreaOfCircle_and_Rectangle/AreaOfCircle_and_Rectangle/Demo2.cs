using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle_and_Rectangle
{
    public class Demo2
    {
        public float total, percentage;
        public int rollno { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }

        public int sub3 { get; set; }

        public int total1()
        {
            total= sub1 + sub2 + sub3;
            return total;
        }

        public float percentge1()
        {
            total = total1();
            percentage = total / 3;
            return percentage;
        }

        public override string ToString()
        {
            return "rollno: "+rollno+"total marks: "+total+"percentage: "+percentage;
        }


    }
}
