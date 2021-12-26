using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    public delegate void Displymsg();
    
    public delegate int MyDelegate(int a, int b); //access specifier / delegate keyword return type / name of delegate (argument list)

    public class Program   //member of class or struct or interface variable, method, event,property
    {

    static void ErrorMsg()
    {
        Console.WriteLine("invalid user");
    }

    static void Main(string[] args)
        {/*
            Console.WriteLine("----delegate----");
            Calculation calculation = new Calculation();     // object of a class
            MyDelegate myDelegate = new MyDelegate(calculation.Add);   //delegate obj holds delegate method
            //int result = myDelegate.Invoke(50, 50);       //invoke method
            //Console.WriteLine("addition: "+result);
            
            myDelegate+=new MyDelegate(calculation.Sub);

            Delegate[] list= myDelegate.GetInvocationList();//gives list of methods
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);  //details of your method 
                Console.WriteLine(item.DynamicInvoke(50,5));
            }*/



            Console.WriteLine("----event----");
            User obj = new User();
            obj.IsValid += new Displymsg(ErrorMsg);  //register event with delegate & delegate hold method ref
            int result = obj.AcceptAge(15);
            Console.WriteLine("age: "+result);
            
        
        
        }
    }

   
}
