using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6_BookDetails
{
    public class Book
    {
        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public decimal Price { get; set; }


        public override string ToString()
        {
            return "BookName: "+BookName+ "\nAuthorName: "+AuthorName+ "\nPrice: "+Price;
        }

    }
}
