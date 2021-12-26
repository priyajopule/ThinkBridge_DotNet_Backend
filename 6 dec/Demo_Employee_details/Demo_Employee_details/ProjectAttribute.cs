using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Employee_details
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=true)]
    public class ProjectAttribute:Attribute
    {
        public string Version { get; set; }

        public string Name { get; set; }


        public override string ToString()
        {
            return "version: "+Version+"name: "+Name;
        }
    }
}
