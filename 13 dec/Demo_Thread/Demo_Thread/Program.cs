using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_Thread
{
   // [Synchronization]  //execute methods in sequence
    public class ThreadDemo
    {
        private string fname, lname;

        //public ThreadDemo()
        //{
        //}

        public ThreadDemo(string fname,string lname)
        {
            this.fname=fname;
            this.lname=lname;
        }

        public void Run()
        {
            Console.WriteLine(fname);
            Thread.Sleep(1000);
            Console.WriteLine(lname);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---thread---");
            ThreadDemo threadDemo =new ThreadDemo("xyz","abc");
            ThreadDemo threadDemo1 = new ThreadDemo("abc","hdgd");
            Thread t1 = new Thread(new ThreadStart(threadDemo.Run));
            Thread t2 = new Thread(new ThreadStart(threadDemo1.Run));
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();






        }
    }
}
