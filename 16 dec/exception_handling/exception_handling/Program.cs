using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    public class Program
    {
        int result;

        Program()
        {

            result = 0;
        }

        public void div(int a, int b)
        {
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exceptioncaught:{o}",e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("thank you.....{0}",result);
            }

           // Console.WriteLine("result:{0}", result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("exception handling");
            Program program=new Program();
            program.div(10, 2);
            Console.ReadKey();
        }
    }
}
