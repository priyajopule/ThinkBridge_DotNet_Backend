using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class AgeException:Exception     //sstem generated exception class
    {
        public AgeException(string msg):base(msg)
        {
            
        }
    }
    public class Person
    {
        public int AcceptAge(int age)
        {
            if(age<18)
            {
                throw new AgeException("not allowed");
            }

            return age;

            
        }
    }
}
