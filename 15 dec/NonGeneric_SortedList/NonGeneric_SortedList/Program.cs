using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric_SortedList
{
    public class Program
    {
        enum colors {red=1,blue=2,pink=3,green=4}
        [flags] enum colorsflags {red=1,blue=2,pink=4,green=8}
        
        
        
        static void Main(string[] args)
        {


            Console.WriteLine((colors.red|colors.blue).ToString());
            Console.WriteLine((colorsflags.pink).ToString());
            
            
            
            /*
            Console.WriteLine("---nongeneric sortedList---");
            SortedList sortedList  = new SortedList();
            sortedList.Add("1","hello hi..");
            sortedList.Add("3", false);
            sortedList.Add("2",00010);*/


            //foreach(KeyValuePair<object,object> i in sortedList)    //
            //{
            //    Console.WriteLine(i.Key+" "+i.Value);
            //}

            /*
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }*/








            /*
            Console.WriteLine("---generic sortedList---");
            SortedList<int,string> sortedList1 = new SortedList<int,string>();
            sortedList1.Add(4, "four");
            sortedList1.Add(2, "two");
            sortedList1.Add(1, "one");
            sortedList1.Add(3, "three");*/
          
            //foreach (var item in sortedList1)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            
            /*
            foreach (KeyValuePair<int, string> kvp in sortedList1)      //using KeyValuePair
            {
                Console.WriteLine(kvp.Key+" "+kvp.Value);
            }*/
 

        }
    }
}
