using System;

namespace Asgn_bank
{

    public delegate void low_bal();
    public delegate void zero_bal();
    public delegate void update_bal();


    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank=new Bank();
            bank.WithAmt(5000);
            bank.DepAmt(2000);
            double result= bank.bal;
            Console.WriteLine(result);

            


        }
    }
}
