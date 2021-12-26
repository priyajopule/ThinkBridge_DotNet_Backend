using System;

namespace AreaOfCircle_and_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Areas");
            Area myarea=new Area {radius=2,length=6,width=4};
            Console.WriteLine("Circle area :"+myarea.Areacircle());
            Console.WriteLine("Rectangle area: "+myarea.AreaRectangle());

           

            //Demo2 demo = new Demo2 {rollno=3,sub1=50,sub2=60,sub3=80 };
           // Console.WriteLine(demo);




        }
    }
}
