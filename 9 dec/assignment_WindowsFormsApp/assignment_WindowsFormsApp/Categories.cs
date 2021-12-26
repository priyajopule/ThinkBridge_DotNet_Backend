using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_WindowsFormsApp
{
    public class Categories
    {
        public int CId { get; set; }

        public string Name { get; set; }

       
    }


    public class Products
    {
        public int PId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int CId { get; set; }



    }

}
