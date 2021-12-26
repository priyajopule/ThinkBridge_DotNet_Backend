using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filehandling_async
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---file handling with async--");
            Task task = new Task(callmethod);
            task.Start();
            task.Wait();
            Console.ReadKey();

        }


        public async void callmethod()
        {
            string filepath = @"D:\dotnetBackend\16 dec\Filehandling_async\Filehandling_async\TextFile.txt";
            Task<int> task = ReadFile(filepath);
            Console.WriteLine("work 1");
            Console.WriteLine("work 2");
            Console.WriteLine("work 3");
            int length = await task;
            Console.WriteLine("total length:"+length);
            Console.WriteLine("after work 1");
            Console.WriteLine("after work 2");
        }


        static async Task<int> ReadFile(string file)
        {
            int length = 0;
            Console.WriteLine("read operation");
            using(StreamReader reader=new StreamReader(file))
            {
                string str= await reader.ReadToEndAsync();
                length = str.Length;
            }
            Console.WriteLine("file reading is completed..");
            return length;
        }
    }
}
/*
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Demo_FileHandling_Async
{​​​​​​​​
    class Program
    {​​​​​​​​
        static void Main(string[] args)
        {​​​​​​​​
            Task task = new Task(callMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();



        }​​​​​​​​


        static async void callMethod()
        {​​​​​​​​
            string filepath = @"C:\Users\DELL\source\Think Bridge Dec 2021\16th Dec\Demo_FileHandling_Async\MyFile.txt";
            Task<int> task = ReadFile(filepath);
            Console.WriteLine("Some other Work 1");
            Console.WriteLine("Some other Work 2");
            Console.WriteLine("Some other Work 3");
            int length = await task;
            Console.WriteLine("Total Length :"+length);


            Console.WriteLine("After Work 1 ");
            Console.WriteLine("After Work 2" );


        }​​​​​​​​


        static async Task<int> ReadFile(string file)
        {​​​​​​​​
            int length = 0;
            Console.WriteLine("Starting with file read OPeration");
            using (StreamReader reader = new StreamReader(file))
            {​​​​​​​​
                //Reads all the character and returns them as one string  
                string s = await reader.ReadToEndAsync();
                length = s.Length;


            }​​​​​​​​
            Console.WriteLine("File Reading is completed ....");
            return length;


        }​​​​​​​​


    }​​​​​​​​
}​​​​​​​​
 











*/