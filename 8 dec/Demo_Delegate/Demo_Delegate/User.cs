using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    public class User
    {
        public event Displymsg IsValid;    // access specifier /using event / delegate name / event name

        public int AcceptAge(int age)
        {
            if(age<18)
            {
                IsValid();    //invoking or calling an event 
            }
            return age;
        }
    }
}
