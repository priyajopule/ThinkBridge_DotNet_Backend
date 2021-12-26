using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NameException : Exception     //system generated exception class
    {
        public NameException(string msg) : base(msg)
        {

        }
    }
    public class Person2
    {
        public string AcceptName(string name)
        {
            if (name=="")
            {
                throw new NameException("string is empty");
            }

            return name;


        }
    }
}
