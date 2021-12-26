using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               int[] scores = new int[] { 97, 92, 80, 60 };


               IEnumerable<int> scoreQuery = from score in scores where score <= 80 select score;


               foreach (int i in scoreQuery)
               {
                   Console.Write(i + " ");
               }*/


            string str = "This Quick brown fox jumps over the lazy dog";
            string[] words = str.Split(' ');
            
            var qry= from word in words                                         //using a query expression syntax
                     group word.ToUpper() by word.Length into gr
                     orderby gr.Key
                     select new {Lengh=gr.Key, words=gr };



            //using method based query

            var qry2 = words.GroupBy(w => w.Length, w => w.ToUpper()).
                       Select(g => new { Length = g.Key, words = g }).
                       OrderBy(o => o.Length);

            
            
            foreach (var item in qry)
            {
                Console.WriteLine("words of length {0}:",item.Lengh);
                foreach (string word in item.words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
