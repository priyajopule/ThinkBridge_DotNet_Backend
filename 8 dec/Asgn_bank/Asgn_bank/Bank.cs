using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asgn_bank
{
    
    public class Bank
    {
        public event low_bal lowBalance;
        public event zero_bal zeroBalance;
        public event update_bal updateBalance;

        public double bal
        {
            get
            { 
                return bal; 
            }
            set
            {
                bal = 10000;
            }
        }

       

        public double DepAmt(double deptAmt) 
        {
            bal = bal + deptAmt;
            return deptAmt;
        }


        public double WithAmt(double amt)
        {
            bal = amt;

            if(amt>bal)
            {
                throw new Exception("balance is low");
            }
            return amt;
        }


        public string low_bal()
        {
            if(bal==0)
            {
                low_bal();
            }
            return lowBalance.ToString();
        }

        public string zero_bal()
        {
            if(bal<3000)
            {
                zero_bal();
            }
            return zeroBalance.ToString();
        }
    }
}
