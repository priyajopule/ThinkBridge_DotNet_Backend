using System;
using System.Collections.Generic;


namespace ProductAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("----arraylist----");           
            ArrayList prlist = new ArrayList();
            Product books = new Product {Code=1,Name="maths",Price=50};
            Product pens = new Product { Code = 2, Name = "english", Price = 15 };
            Product papers = new Product { Code = 3, Name = "hindi", Price = 20 };
            prlist.Add(books);
            prlist.Add(pens);
            prlist.Add(papers);
            foreach (var item in prlist)
            {
                Console.WriteLine(item);
            }
           */




            /*
             Console.WriteLine("----hashtable-----");
             Hashtable ht = new Hashtable();   //hashing alog will be used to store and retrive data
             ht.Add(1, "one");
             ht.Add(2, "two");
             ht.Add(3, "three");
             ht.Add(4, "four");
             //ht.Remove(3);
             foreach (DictionaryEntry item in ht)    //structure type
             {
                 Console.WriteLine(item.Key + "    "+item.Value);
             }


             */




            Console.WriteLine("---list----");
           
            List<string> list = new List<string>();
            list.Add("sub1");
            list.Add("sub7");
            list.Add("sub3");
           
            foreach (var item in list)
            {
                Console.WriteLine("before sorting: "+item);
            }

            list.Sort();
            Console.WriteLine("-----after sorting-----");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            

            Console.WriteLine("------stack-------");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("------queue------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }



        }
    }
}
