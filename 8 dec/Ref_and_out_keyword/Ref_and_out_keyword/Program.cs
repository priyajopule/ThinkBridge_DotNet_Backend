using System;

namespace Ref_and_out_keyword
{
    public class Program
    {
        //reference keyword concept
        //ref--> hold the address not value   and   out-->returns multiple value
        /*
        static void Add(ref int a, ref int b,out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---reference & out keyword---");
            int a = 10, b = 20, sum, mul;
            Add(ref a, ref b, out sum, out mul);
            Console.WriteLine("addition: "+sum);
            Console.WriteLine("multiplication: "+mul);
        }*/
        

        static void Main(string[] args)
        {
            Console.WriteLine("----square & cube---");
            int a = 2, Sq, cu;
            Cal(ref a,out Sq,out cu);
            Console.WriteLine("square: "+Sq);
            Console.WriteLine("cube: "+cu);
            
        }

        static void Cal(ref int a, out int square, out int cube)
        {
            square = a * a;
            cube = a * a * a;
        }

    }
}
