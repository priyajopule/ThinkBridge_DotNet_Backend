using System;

namespace Demo_is_and_as_operator
{
    
    class class1
    {

    }
    
    class class2
    {

    }

    public class Istest
    {
        
    }
    
    
    internal class Program
    {

        public static void Test(object o) ///when you define obj it store everything 
        {
            class1 obj1;
            class2 obj2;
            if (o is class1)
            {
                Console.WriteLine("o is class1");
                obj1 = (class1)o;
            }
            else if (o is class2)
            {
                Console.WriteLine("o is class2");
                obj2 = (class2)o;
            }
            else
            {
                Console.WriteLine("o is neither class1 nor class2");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------demo on IS operator-------- ");
            class1 c1 = new class1();// process of creating class object isknown as instanciation
            class2 c2 = new class2();
            Test(c1);
            Test(c2);
            Test("hello----");
            Console.ReadKey();
        }
    }
}
