using System;
using System.Collections;

namespace Collections_and_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("----collections---");
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add("hello");
            list.Insert(1, 50);   //adding in specific index position
            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/



            Stack st=new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            foreach(int i in st)
            {
                Console.WriteLine("stack values: "+i);
            }


            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine("after pop: "+item);
            }


            Console.WriteLine("--------------");

            Queue q = new Queue();
            q.Enqueue("yes");
            q.Enqueue("no");
            q.Enqueue("yes");
            foreach (var item in q)
            {
                Console.WriteLine("Queue values: "+item);
            }
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine("after removing: "+item);
            }
            
        }
    }
}
