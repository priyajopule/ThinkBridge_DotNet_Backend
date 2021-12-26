using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on_Abstract
{

    public interface ICustomer
    {
        string Printdetails();
    }

    public interface IOrder
    {
        string Printdetails();
    }
    
    public class Transaction: ICustomer, IOrder
    {
        string ICustomer.Printdetails()
        {
            return "hello";
        }

        string IOrder.Printdetails()
        {
            return "hello";
        }

    }
}
