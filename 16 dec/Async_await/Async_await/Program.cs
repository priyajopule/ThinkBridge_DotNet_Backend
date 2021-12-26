using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_await
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Task1();
            // Task2();
            await CallTask();
            Console.ReadKey();
           
        }

       
        
        public static async Task CallTask()
        {
            Task<int> task = Task1();
            Task2();
            int count = await task;
            Task3(count);
        }
        
        
        
        public static async Task <int> Task1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i <= 40; i++)
                {
                    Console.WriteLine("Task1//////");
                    count += 1;
                    //Task.Delay(100).Wait();
                }
            });
            return count;
        }


        public static void Task2()
        {
            for(int i=0; i<=20 ;i++)
            {
                Console.WriteLine("Task2.....");
               // Task.Delay(150).Wait();

            }
        }

        public static void Task3(int count)
        {
            Console.WriteLine("Total count: "+count);
        }
    }
}
