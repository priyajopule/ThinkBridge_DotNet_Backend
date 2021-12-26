using System;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("---exception handling----");
            Calculation c1 = new Calculation();
            try
            {
                int result = c1.Divide(4, 0);
                Console.WriteLine(result);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("0 can not be used: "+ex.Message);
            }

            catch(ArithmeticException ex)
            {
                Console.WriteLine("in the arithmatic exception");
            }

            finally
            {
                Console.WriteLine("finally block is running");
            }
        }*/


            /*
            Person person = new Person();
            try
            {
                int age = person.AcceptAge(25);
                Console.WriteLine("you are allowed: " + age);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */



            Person2 person = new Person2();
            try
            {
                string name = person.AcceptName("");
                Console.WriteLine("your name: " + name);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }


}
