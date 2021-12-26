using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAssignment
{
    public class Product
    {
        public int Code{ get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return "code: "+Code+ "\nname: "+Name+ "\nprice: "+Price;

        }


    }
}
