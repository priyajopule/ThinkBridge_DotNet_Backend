using System;


namespace Demo_Employee_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee emp1 = new Employee();
            Console.WriteLine(emp1);
            Employee emp2 = new Employee(30000,"priyanka");
            Console.WriteLine(emp2);*/
            
            
            //derived 
            /*
            SalesManager sales = new SalesManager("john", 35000, 2550);
            sales.Calculate();
            Console.WriteLine(sales);*/


           // ProductManager product=new ProductManager("hello",20000,3000,2000);





            Attribute[] list = Attribute.GetCustomAttributes(typeof(Employee));
            foreach (Attribute attr in list)
            {
                Console.WriteLine(attr);
            }
        }
    }
}
