using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_join_LINQ
{
    internal class Product
    {
        public int CategoryID { get; set; }

        public string PName { get; set; }
    }


    class Category
    {
        public int CID { get; set; }

        public string CategoryName { get; set; }
    }
}
