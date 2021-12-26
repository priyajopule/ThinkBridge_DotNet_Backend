using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userdefined_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----user defined exception----");
            temperature temperature = new temperature();
            try
            {
                temperature.showtemp();
            }
            catch(TempIszZeroExcption e)
            {
                Console.WriteLine("temperature is zero:{0}",e.Message);
            }
        }
    }


    public class TempIszZeroExcption : Exception   // eception is a base class
    { 
        public TempIszZeroExcption(string message):base(message)    //base() refers message frombase class
        { }
    
    }
    public class temperature
    {
        int temerature = 0;

        public void showtemp()
        {
            if (temerature == 0)
            {
                throw (new TempIszZeroExcption("zero temperature found"));
            }
            else
            {
                Console.WriteLine("temperature:{0}",temerature);
            }
        }
    }
}
