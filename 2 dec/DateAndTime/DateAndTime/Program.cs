using System;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Date and Time:");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.DaysInMonth(2020,02));
            Console.WriteLine(DateTime.Today);

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i+"--->"+DateTime.Now.TimeOfDay.ToString());
                System.Threading.Thread.Sleep(200);
            }

            DateTime todaysdate = DateTime.Today;
            Console.WriteLine("todays day and date is: " + todaysdate.ToString("dddd dd MMMM yyyy"));
        }
    }
}
