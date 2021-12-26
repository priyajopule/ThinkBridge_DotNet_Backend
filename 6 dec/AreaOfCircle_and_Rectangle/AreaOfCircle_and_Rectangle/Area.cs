using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle_and_Rectangle
{
    public class Area
    {
        public float radius { get; set; }
        public int length { get; set; }

        public int width { get; set; }

        public float Areacircle()
        {
            return 3.14* radius * radius;
        }

        public int AreaRectangle()
        {
            return length * width;
        }



    
    
    }

  

}
