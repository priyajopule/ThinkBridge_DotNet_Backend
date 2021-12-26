using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on_Abstract
{
    abstract public class Shape
    {
        public abstract void CalArea();   //default virtual
    }

    public class Rectangle : Shape,IPrintable   //derived class from base class shapee     //using interface IPrintable
    {
        private int len, wid;
        private double result;

        public Rectangle(int len, int wid)
        {
            this.len = len;
            this.wid = wid;
        }
        public override void CalArea()
        {
            result = len * wid;
        }

        public override string ToString()
        {
            return "AofRectangle: " + result;
        }

        public String Printdetails() 
        {
            return "AofRectangle: " + result;
        }
    
    }

 



}
