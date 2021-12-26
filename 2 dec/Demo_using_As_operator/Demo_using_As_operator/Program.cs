using System;

namespace Demo_using_As_operator
{ }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----demo using AS opeator----");
            object[] Myobj = new object[4];//creating object as array 
            Myobj[0] = "String";
            Myobj[1] = 111;
            Myobj[2] = "hello";
            Myobj[3] = new classOne();

            for(int i=0; i<Myobj.Length;i++)
            {
                string a = Myobj[i] as string;//checking if it is string or not
                Console.Write("{0}:",i);
                if(a != null)
                    {
                         Console.WriteLine("'"+a+"'"+"is a string");
                    }
                else
                    {
                        Console.WriteLine("it is not a string");
                    }
            }
            
        }
    }

    internal class classOne
{

}

