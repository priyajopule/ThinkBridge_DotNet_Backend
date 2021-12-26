using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on_Abstract
{
    public interface IPrintable
    {
        string Printdetails();  //by default methods are virtual and abstract & access is public
                                //we can not write data members , can be auto implemented properties 
    }
}
