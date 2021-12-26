using System;

namespace MultiDimentionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Demo 2D array");
            //int[,] matrix = new int[2, 2]
            //{
            //    {1,2 },  //row indexed by 0
            //    {3,4 }   //row indexed by 1
            //};

            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(item);
            //}

            //matrix [1, 1] = 100;

            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("----Jagged array---");
            //datatype[][]name of my array = new datatype[rows][]
            int [][] jaggedArr = new int[4][];
            
            jaggedArr[0] = new int[2] {1,2};
            jaggedArr[1] = new int[3] {20,30,40};
            jaggedArr[2] = new int[3] {50,6,70};
            jaggedArr[3] = new int[1] {10};

            for (int i = 0;i<jaggedArr.Length ;i++)
            {
                Console.Write("row{0} ",i);
                for (int j = 0;j<jaggedArr[i].Length ;j++)
                {
                    Console.WriteLine("{0} ",jaggedArr[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
